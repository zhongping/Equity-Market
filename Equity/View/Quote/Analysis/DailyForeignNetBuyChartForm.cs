using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Equity.Helper;
using Equity.Repository;
using Equity.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace Equity.View.Quote.Analysis
{
    public partial class DailyForeignNetBuyChartForm : Form
    {
        StockRepository stockRepo;
        StockQuoteRepository quoteRepo;

        public DailyForeignNetBuyChartForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool validated = this.ValidateInput();
            if (validated)
            {
                this.LoadData(int.Parse(TickerComboBox.SelectedValue.ToString()));
            }
        }

        private void DailyForeignNetBuyChartForm_Load(object sender, EventArgs e)
        {
            stockRepo = new StockRepository();
            quoteRepo = new StockQuoteRepository();
            DataHelper.LoadTickerComboBox(stockRepo, TickerComboBox);
        }

        private bool ValidateInput()
        {
            bool valid = true;
            return valid;
        }

        private void LoadData(int id)
        {
            stock stock = stockRepo.GetStockById(id);
            List<foreign_buy_sell> foreignList = quoteRepo.GetForeignNetBuy(stock.code);
            List<stock_quotes> quoteList = quoteRepo.LoadStockQuoteByCode(stock.code);
            if (quoteList != null && foreignList != null)
            {
                foreach (var series in ForeignDailyChart.Series) { series.Points.Clear(); }
                ForeignDailyChart.Titles.Clear();
                this.DrawForeignBuyChart(quoteList, foreignList);
            }
            else
            {
                MessageBox.Show("Data is not found");
            }
        }

        private void DrawForeignBuyChart(List<stock_quotes> quoteList, List<foreign_buy_sell> foreignList)
        {
            //First Series, left hand side Y-Axis
            ForeignDailyChart.Series["Daily Quote"]["OpenCloseStyle"] = "Triangle";
            ForeignDailyChart.Series["Daily Quote"]["ShowOpenClose"] = "Both";
            ForeignDailyChart.Series["Daily Quote"]["PointWidth"] = "0.7";
            ForeignDailyChart.Series["Daily Quote"]["PriceUpColor"] = "Green";
            ForeignDailyChart.Series["Daily Quote"]["PriceDownColor"] = "Red";

            for (int i = 0; i < quoteList.Count; i++)
            {
                ForeignDailyChart.Series["Daily Quote"].Points.AddXY(quoteList[i].quote_date.ToString("dd-MM"), quoteList[i].high);
                ForeignDailyChart.Series["Daily Quote"].Points[i].YValues[1] = Double.Parse(quoteList[i].low.ToString());
                ForeignDailyChart.Series["Daily Quote"].Points[i].YValues[2] = Double.Parse(quoteList[i].open.ToString());
                ForeignDailyChart.Series["Daily Quote"].Points[i].YValues[3] = Double.Parse(quoteList[i].close.ToString());
            }
            ForeignDailyChart.Series["Daily Quote"].YAxisType = AxisType.Primary;

            //Second Series, right hand side Y-Axis
     
            foreach (foreign_buy_sell foreign in foreignList)
            {
                ForeignDailyChart.Series["Foreign Net Buy"].Points.AddXY(foreign.quote_date.ToString("dd-MM"), foreign.foreign_net_buy);
            }
            ForeignDailyChart.Series["Foreign Net Buy"].YAxisType = AxisType.Secondary;

            ForeignDailyChart.ChartAreas["ForeignChartArea"].AxisY.IsStartedFromZero = false;
            ForeignDailyChart.ChartAreas["ForeignChartArea"].AxisX.MajorGrid.Enabled = false;
            ForeignDailyChart.ChartAreas["ForeignChartArea"].AxisY.MajorGrid.Enabled = false;
            ForeignDailyChart.ChartAreas["ForeignChartArea"].AxisY2.MajorGrid.Enabled = false;
            ForeignDailyChart.ChartAreas["ForeignChartArea"].AxisY2.Enabled = AxisEnabled.True;
            ForeignDailyChart.ChartAreas["ForeignChartArea"].AxisY2.IsStartedFromZero = ForeignDailyChart.ChartAreas["ForeignChartArea"].AxisY.IsStartedFromZero;
            ForeignDailyChart.Titles.Add(TickerComboBox.Text.ToUpper());
        }
            
    }
}
