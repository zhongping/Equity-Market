using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Equity.Repository;
using Equity.Model;


namespace Equity.View
{
    public partial class StockChartForm : Form
    {
        private EquityRepository equityRepo;

        public StockChartForm()
        {
            InitializeComponent();
            this.equityRepo = new EquityRepository();
        }

        private void StockChartForm_Load(object sender, EventArgs e)
        {
            StockChartLabel.Text = "";
            StockChartMonthDateTimePicker.Format = DateTimePickerFormat.Custom;
            StockChartMonthDateTimePicker.CustomFormat = "MM/yyyy";
            StockChartMonthDateTimePicker.ShowUpDown = true;
            StockChartMonthDateTimePicker.Value = DateTime.Today.AddMonths(-1);
        }

        private void StockSearchButton_Click(object sender, EventArgs e)
        {
            bool success = this.ValidateStockChartForm();
            if (success)
            {
                this.LoadEquity();
            }
        }

        private void LoadEquity()
        {
            equity_holding equity_holding = equityRepo.MonthlyLoadEquity(StockChartTextBox.Text, StockChartMonthDateTimePicker.Value);
            if (equity_holding != null)
            {
                foreach(var series in StockHoldingChart.Series) { series.Points.Clear(); }
                StockHoldingChart.Titles.Clear();
                this.DrawChart(equity_holding);
            }
            else
            {
                MessageBox.Show("Data is not found");
            }
        }

        private void DrawChart(equity_holding equity_holding)
        {
            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Insurance", equity_holding.Domestic_Insurance);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Insurance", equity_holding.Foreign_Insurance);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Company", equity_holding.Domestic_Company);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Company", equity_holding.Foreign_Company);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Pension Fund", equity_holding.Domestic_Pension_Fund);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Pension Fund", equity_holding.Foreign_Pension_Fund);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Bank", equity_holding.Domestic_Bank);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Bank", equity_holding.Foreign_Bank);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Individual", equity_holding.Domestic_Individual);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Individual", equity_holding.Foreign_Individual);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Mutual Fund", equity_holding.Domestic_Mutual_Fund);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Mutual Fund", equity_holding.Foreign_Mutual_Fund);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Security", equity_holding.Domestic_Security);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Security", equity_holding.Foreign_Security);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Foundation", equity_holding.Domestic_Foundation);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Foundation", equity_holding.Foreign_Foundation);

            StockHoldingChart.Series["Domestic Holding"].Points.AddXY("Others", equity_holding.Domestic_Others);
            StockHoldingChart.Series["Foreign Holding"].Points.AddXY("Others", equity_holding.Foreign_Others);

            StockHoldingChart.Titles.Add("Holding Chart");
        }

        private bool ValidateStockChartForm()
        {
            bool isChecked = true;
            if (StockChartTextBox.Text == "")
            {
                MessageBox.Show("Please input the stock ticker");
                isChecked = false;
            }
            if (StockChartTextBox.Text.Length != 4)
            {
                MessageBox.Show("Ticker should be 4 characters");
                isChecked = false;
            }
            if (StockChartMonthDateTimePicker.Value.ToString() == "")
            {
                MessageBox.Show("Please input the month");
                isChecked = false;
            }
            return isChecked;
        }
    }
}
