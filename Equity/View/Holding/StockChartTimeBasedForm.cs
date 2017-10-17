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
using System.Windows.Forms.DataVisualization.Charting;

namespace Equity.View
{
    public partial class StockChartTimeBasedForm : Form
    {
        private EquityRepository equityRepo;

        public StockChartTimeBasedForm()
        {
            InitializeComponent();
            this.equityRepo = new EquityRepository();
        }

        private void StockChartTimeBasedForm_Load(object sender, EventArgs e)
        {
            FromDateTimePicker.Format = DateTimePickerFormat.Custom;
            FromDateTimePicker.CustomFormat = "MM/yyyy";
            FromDateTimePicker.ShowUpDown = true;
            FromDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            ToDateTimePicker.Format = DateTimePickerFormat.Custom;
            ToDateTimePicker.CustomFormat = "MM/yyyy";
            ToDateTimePicker.ShowUpDown = true;
            ToDateTimePicker.Value = DateTime.Today.AddMonths(-1);
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
            List<equity_holding> equityList = this.equityRepo.LoadEquityList(StockTextBox.Text, FromDateTimePicker.Value, ToDateTimePicker.Value);
            if (equityList != null)
            {
                foreach (var series in StockChart.Series) { series.Points.Clear(); }
                StockChart.Titles.Clear();
                this.DrawChart(equityList);
            }
            else
            {
                MessageBox.Show("Data is not found");
            }
        }

        private void DrawChart(List<equity_holding> equityList)
        {
            foreach (equity_holding equity in equityList)
            {
                StockChart.Series["Domestic Insurance"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Insurance);
                StockChart.Series["Domestic Company"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Company);
                StockChart.Series["Domestic Pension Fund"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Pension_Fund);
                StockChart.Series["Domestic Bank"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Bank);
                StockChart.Series["Domestic Individual"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Individual);
                StockChart.Series["Domestic Mutual Fund"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Mutual_Fund);
                StockChart.Series["Domestic Security"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Security);
                StockChart.Series["Domestic Foundation"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Foundation);
                StockChart.Series["Domestic Others"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Domestic_Others);

                StockChart.Series["Foreign Insurance"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Insurance);
                StockChart.Series["Foreign Insurance"].Color = Color.FromArgb(128, 255, 0, 0);

                StockChart.Series["Foreign Company"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Company);
                StockChart.Series["Foreign Company"].Color = Color.FromArgb(128, 255, 192, 128);

                StockChart.Series["Foreign Pension Fund"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Pension_Fund);
                StockChart.Series["Foreign Pension Fund"].Color = Color.FromArgb(128, 255, 128, 255);

                StockChart.Series["Foreign Bank"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Bank);
                StockChart.Series["Foreign Bank"].Color = Color.FromArgb(128, 255, 255, 0);

                StockChart.Series["Foreign Individual"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Individual);
                StockChart.Series["Foreign Individual"].Color = Color.FromArgb(128, 0, 255, 0);

                StockChart.Series["Foreign Mutual Fund"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Mutual_Fund);
                StockChart.Series["Foreign Mutual Fund"].Color = Color.FromArgb(128, 64, 0, 64);

                StockChart.Series["Foreign Security"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Security);
                StockChart.Series["Foreign Security"].Color = Color.FromArgb(128, 0, 206, 209);

                StockChart.Series["Foreign Foundation"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Foundation);
                StockChart.Series["Foreign Foundation"].Color = Color.FromArgb(128, 0, 139, 139);

                StockChart.Series["Foreign Others"].Points.AddXY(equity.Date.ToString("MMMM-yyyy"), equity.Foreign_Others);
                StockChart.Series["Foreign Others"].Color = Color.FromArgb(128, 173, 255, 47);
            }
            StockChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            StockChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            StockChart.Titles.Add(StockTextBox.Text.ToUpper());
        }

        private bool ValidateStockChartForm()
        {
            bool isChecked = true;
            if (StockTextBox.Text == "")
            {
                MessageBox.Show("Please input the stock ticker");
                isChecked = false;
            }
            if (StockTextBox.Text.Length != 4)
            {
                MessageBox.Show("Ticker should be 4 characters");
                isChecked = false;
            }
            return isChecked;
        }


    }
}
