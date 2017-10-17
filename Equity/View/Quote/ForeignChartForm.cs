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
    public partial class ForeignChartForm : Form
    {
        StockQuoteRepository quoteRepo;

        public ForeignChartForm()
        {
            InitializeComponent();
            quoteRepo = new StockQuoteRepository();
        }

        private void ForeignChartForm_Load(object sender, EventArgs e)
        {
            ForeignStockLabel.Text = "";
            ForeignStockNameLabel.Text = "";
        }

        private void foreignChartButton_Click(object sender, EventArgs e)
        {
            bool success = this.ValidateForeignChartForm();
            if (success)
            {
                this.LoadForeignBuyData(ForeignChartTextBox.Text.ToUpper().Trim());
            }
        }

        private void LoadForeignBuyData(string code)
        {
            List<foreign_buy_sell> foreignList = quoteRepo.GetForeignNetBuy(code);
            if (foreignList != null)
            {
                foreach (var series in ForeignChart.Series) { series.Points.Clear(); }
                ForeignChart.Titles.Clear();
                this.DrawForeignChart(foreignList);
            }
            else
            {
                MessageBox.Show("Data is not found");
            }
        }

        private void DrawForeignChart(List<foreign_buy_sell> foreignList)
        {
            foreach (foreign_buy_sell foreign in foreignList)
            {
                ForeignChart.Series["Foreign Net Buy"].Points.AddXY(foreign.quote_date.ToString("dd-MM"), foreign.foreign_net_buy);
            }
            ForeignChart.ChartAreas["ChartArea1"].AxisY.IsStartedFromZero = false;
            ForeignChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            ForeignChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            ForeignChart.Titles.Add(ForeignChartTextBox.Text.ToUpper());
        }

        private bool ValidateForeignChartForm()
        {
            bool isChecked = true;
            if (ForeignChartTextBox.Text == "")
            {
                MessageBox.Show("Please input the stock ticker");
                isChecked = false;
            }
            if (ForeignChartTextBox.Text.Length != 4)
            {
                MessageBox.Show("Ticker should be 4 characters");
                isChecked = false;
            }
            return isChecked;
        }

        
    }
}
