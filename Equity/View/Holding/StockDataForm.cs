using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equity.Model;
using Equity.Repository;

namespace Equity.View
{
    public partial class StockDataForm : Form
    {
        private EquityRepository equityRepo;

        public StockDataForm()
        {
            InitializeComponent();
            equityRepo = new EquityRepository();
        }

        private void StockDataForm_Load(object sender, EventArgs e)
        {
            StockDateTimePicker.Format = DateTimePickerFormat.Custom;
            StockDateTimePicker.CustomFormat = "MM/yyyy";
            StockDateTimePicker.ShowUpDown = true;
            StockDateTimePicker.Value = DateTime.Today.AddMonths(-1);
        }

        private void StockSearchbutton_Click(object sender, EventArgs e)
        {
            bool success = this.ValidateInput();
            if (success)
            {
                this.LoadData();
            }
        }

        private bool ValidateInput()
        {
            bool isChecked = true;
            if (TickerTextBox.Text == "")
            {
                MessageBox.Show("Please input the stock ticker");
            }
            if (TickerTextBox.Text.Length != 4)
            {
                MessageBox.Show("Ticker should be 4 characters");
            }
            if (StockDateTimePicker.Value.ToString() == "")
            {
                MessageBox.Show("Please input the month");
            }
            return isChecked;
        }

        private void LoadData()
        {
            equity_holding equity = equityRepo.MonthlyLoadEquity(TickerTextBox.Text, StockDateTimePicker.Value);
            if (equity != null)
            {
                this.DisplayData(equity);
            }
            else
            {
                MessageBox.Show("Stock is not found");
            }
        }

        private void DisplayData(equity_holding equity) {
            StockTickerLabel.Text = equity.Code;
            StockDateTimePicker.Value = equity.Date;
            PriceLabel.Text = equity.Price.ToString();

            //Domestic
            DomInsVaLabel.Text = equity.Domestic_Insurance.ToString();
            DomComValabel.Text = equity.Domestic_Company.ToString();
            DomPFVaLabel.Text = equity.Domestic_Pension_Fund.ToString();
            DomBankVaLabel.Text = equity.Domestic_Bank.ToString();
            DomIndVaLabel.Text = equity.Domestic_Individual.ToString();
            DomMFVaLabel.Text = equity.Domestic_Mutual_Fund.ToString();
            DomSecVaLabel.Text = equity.Domestic_Security.ToString();
            DomFoundVaLabel.Text = equity.Domestic_Foundation.ToString();
            DomOthersVaLabel.Text = equity.Domestic_Others.ToString();
            decimal? domTotal = equity.Domestic_Insurance + equity.Domestic_Company + equity.Domestic_Pension_Fund + equity.Domestic_Bank + equity.Domestic_Individual + equity.Domestic_Mutual_Fund + equity.Domestic_Security + equity.Domestic_Foundation + equity.Domestic_Others;
            DomTotVaLabel.Text = domTotal.ToString();

            //Foreign
            ForInsVaLabel.Text = equity.Foreign_Insurance.ToString();
            ForCompVaLabel.Text = equity.Foreign_Company.ToString();
            ForPFVaLabel.Text = equity.Foreign_Pension_Fund.ToString();
            ForBankVaLabel.Text = equity.Foreign_Bank.ToString();
            ForIndVaLabel.Text = equity.Foreign_Individual.ToString();
            ForMFVaLabel.Text = equity.Foreign_Mutual_Fund.ToString();
            ForSecVaLabel.Text = equity.Foreign_Security.ToString();
            ForFoundVaLabel.Text = equity.Foreign_Foundation.ToString();
            ForOthersVaLabel.Text = equity.Foreign_Others.ToString();
            decimal? ForTotal = equity.Foreign_Insurance + equity.Foreign_Company + equity.Foreign_Pension_Fund + equity.Foreign_Bank + equity.Foreign_Individual + equity.Foreign_Mutual_Fund + equity.Foreign_Security + equity.Foreign_Foundation + equity.Foreign_Others;
            ForTotVaLabel.Text = ForTotal.ToString();
        }

        private void StockDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            equityRepo.Dispose();
            this.Close();
        }
    }
}
