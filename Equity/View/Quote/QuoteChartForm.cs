using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equity.Repository;
using Equity.Model;

namespace Equity.View.Quote
{
    public partial class QuoteChartForm : Form
    {
        StockQuoteRepository quoteRepo;
        StockRepository stockRepo;

        public QuoteChartForm()
        {
            InitializeComponent();
            quoteRepo = new StockQuoteRepository();
            stockRepo = new StockRepository();
        }

        private void QuoteChartForm_Load(object sender, EventArgs e)
        {
            QuoteChartLabel.Text = "";
            QuoteNameLabel.Text = "";
        }

        private void QuoteChartButton_Click(object sender, EventArgs e)
        {
            bool success = this.ValidateChartForm();
            if (success)
            {
                this.LoadQuoteData(QuoteChartTextBox.Text.ToUpper().Trim());
            }
        }

        private void LoadQuoteData(string code)
        {
            List<stock_quotes> quoteList = quoteRepo.LoadStockQuoteByCode(code);
            if (quoteList != null)
            {
                foreach (var series in QuoteChart.Series) { series.Points.Clear(); }
                QuoteChart.Titles.Clear();
                this.DrawQuoteChart(quoteList);
            }
            else
            {
                MessageBox.Show("Data is not found");
            }
        }

        private void DrawQuoteChart(List<stock_quotes> quoteList)
        {
            QuoteChart.Series["Daily Quote"]["OpenCloseStyle"] = "Triangle";
            QuoteChart.Series["Daily Quote"]["ShowOpenClose"] = "Both";
            QuoteChart.Series["Daily Quote"]["PointWidth"] = "1.0";
            QuoteChart.Series["Daily Quote"]["PriceUpColor"] = "Green";
            QuoteChart.Series["Daily Quote"]["PriceDownColor"] = "Red";

            for (int i = 0; i < quoteList.Count; i++)
            {
                QuoteChart.Series["Daily Quote"].Points.AddXY(quoteList[i].quote_date.ToString("dd-MM"), quoteList[i].high);
                QuoteChart.Series["Daily Quote"].Points[i].YValues[1] = Double.Parse(quoteList[i].low.ToString());
                QuoteChart.Series["Daily Quote"].Points[i].YValues[2] = Double.Parse(quoteList[i].open.ToString());
                QuoteChart.Series["Daily Quote"].Points[i].YValues[3] = Double.Parse(quoteList[i].close.ToString());
            }
            QuoteChart.ChartAreas["ChartArea1"].AxisY.IsStartedFromZero = false;
            QuoteChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            QuoteChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            QuoteChart.Titles.Add(QuoteChartTextBox.Text.ToUpper());
        }

        private bool ValidateChartForm()
        {
            bool isChecked = true;
            if (QuoteChartTextBox.Text == "")
            {
                MessageBox.Show("Please input the stock ticker");
                isChecked = false;
            }
            if (QuoteChartTextBox.Text.Length != 4)
            {
                MessageBox.Show("Ticker should be 4 characters");
                isChecked = false;
            }
            return isChecked;
        }
    }
}
