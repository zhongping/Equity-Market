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
    public partial class StockChartTotalForm : Form
    {
        private EquityRepository equityRepo;
        public StockChartTotalForm()
        {
            InitializeComponent();
            this.equityRepo = new EquityRepository();
        }

        private void StockChartTotalForm_Load(object sender, EventArgs e)
        {
            FromTotalDateTimePicker.Format = DateTimePickerFormat.Custom;
            FromTotalDateTimePicker.CustomFormat = "MM/yyyy";
            FromTotalDateTimePicker.ShowUpDown = true;
            FromTotalDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            ToTotalDateTimePicker.Format = DateTimePickerFormat.Custom;
            ToTotalDateTimePicker.CustomFormat = "MM/yyyy";
            ToTotalDateTimePicker.ShowUpDown = true;
            ToTotalDateTimePicker.Value = DateTime.Today.AddMonths(-1);
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
            List<total_composition> equityList = this.equityRepo.LoadTotalHolding(StockSearchedTextBox.Text.ToUpper(), FromTotalDateTimePicker.Value, ToTotalDateTimePicker.Value);
            if (equityList != null)
            {
                foreach (var series in StockTotalChart.Series) { series.Points.Clear(); }
                StockTotalChart.Titles.Clear();
                this.DrawChart(equityList);
            }
            else
            {
                MessageBox.Show("Data is not found");
            }
        }

        private void DrawChart(List<total_composition> equityList)
        {
            foreach (total_composition equity in equityList)
            {
                StockTotalChart.Series["Domestic Total"].Points.AddXY(equity.date.ToString("MMMM-yyyy"), equity.Domestic_Total);
                StockTotalChart.Series["Foreign Total"].Points.AddXY(equity.date.ToString("MMMM-yyyy"), equity.Foreign_Total);
            }
            StockTotalChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            StockTotalChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            StockTotalChart.Titles.Add(StockSearchedTextBox.Text.ToUpper());
        }

        private bool ValidateStockChartForm()
        {
            bool isChecked = true;
            if (StockSearchedTextBox.Text == "")
            {
                MessageBox.Show("Please input the stock ticker");
                isChecked = false;
            }
            if (StockSearchedTextBox.Text.Length != 4)
            {
                MessageBox.Show("Ticker should be 4 characters");
                isChecked = false;
            }
            return isChecked;
        }

  
    }
}
