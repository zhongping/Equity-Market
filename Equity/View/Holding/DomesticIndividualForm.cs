using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Equity.Repository;
using Equity.Model;

namespace Equity.View.Holding
{
    public partial class DomesticIndividualForm : Form
    {
        private EquityRepository equityRepo;
        public DomesticIndividualForm()
        {
            InitializeComponent();
            this.equityRepo = new EquityRepository();
        }

        private void DomesticIndividualForm_Load(object sender, EventArgs e)
        {
    
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
            List<domestic_individual> equityList = this.equityRepo.GetIndividualHolding(StockSearchedTextBox.Text.ToUpper());
            if (equityList != null)
            {
                foreach (var series in DomesticIndividualChart.Series) { series.Points.Clear(); }
                DomesticIndividualChart.Titles.Clear();
                this.DrawChart(equityList);
            }
            else
            {
                MessageBox.Show("Data is not found");
            }
        }

        private void DrawChart(List<domestic_individual> equityList)
        {
            foreach (domestic_individual equity in equityList)
            {
                DomesticIndividualChart.Series["Domestic Individual"].Points.AddXY(equity.date.ToString("MMMM-yyyy"), equity.Domestic_Individual);
                DomesticIndividualChart.Series["Foreign Total"].Points.AddXY(equity.date.ToString("MMMM-yyyy"), equity.foreign_non_individual);
            }
            DomesticIndividualChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            DomesticIndividualChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            DomesticIndividualChart.Titles.Add(StockSearchedTextBox.Text.ToUpper());
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
