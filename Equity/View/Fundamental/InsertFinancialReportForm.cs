using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Equity.Model;
using Equity.Repository;
using Equity.Helper;

namespace Equity.View.Fundamental
{
    public partial class InsertFinancialReportForm : Form
    {
        StockRepository stockRepo;
        FinancialReportRepository financialRepo;


        public InsertFinancialReportForm()
        {
            InitializeComponent();
            stockRepo = new StockRepository();
            financialRepo = new FinancialReportRepository();

            AssetTextBox.KeyPress += new KeyPressEventHandler(AssetTextBox_KeyPress);
            LiabilitiesTextBox.KeyPress += new KeyPressEventHandler(LiabilitiesTextBox_KeyPress);
            SalesTextBox.KeyPress += new KeyPressEventHandler(SalesTextBox_KeyPress);
            EquityTextBox.KeyPress += new KeyPressEventHandler(EquityTextBox_KeyPress);
            GrossProfitTextBox.KeyPress += new KeyPressEventHandler(GrossProfitTextBox_KeyPress);
            NetIncomeTextBox.KeyPress += new KeyPressEventHandler(NetIncomeTextBox_KeyPress);
            CashFlowTextBox.KeyPress += new KeyPressEventHandler(CashFlowTextBox_KeyPress);
        }

        private void CashFlowTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void NetIncomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void GrossProfitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void EquityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void SalesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void LiabilitiesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void AssetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back)) 
            {
                e.Handled = true; 
                MessageBox.Show("Please input numeric only");
            }
        }

        private void InsertFinancialReportForm_Load(object sender, EventArgs e)
        {
            
            DataHelper.LoadTickerComboBox(stockRepo, TickerComboBox);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            bool validated = this.ValidateInput();
            if (validated)
            {
                this.SaveFinancialReport();
            }
        }

        private void SaveFinancialReport()
        {
            string message = String.Empty;
            financial financial = this.PopulateFinancial();
            bool recorded = this.CheckFinancialDate((int)TickerComboBox.SelectedValue, FinancialDateTimePicker.Value.Date);
            if(!recorded)
            {
                bool success = this.financialRepo.SaveFinancialReport(financial, out message);
                if(success)
                {
                    MessageBox.Show("Financial Report Data has been saved");
                }
            }
            else
            {
                MessageBox.Show("Financial Report for " + TickerComboBox.Text + " at the date of " + FinancialDateTimePicker.Value.Date + " already recorded in database");
                this.ClearFields();
            }
        }

        private financial PopulateFinancial()
        {
            financial fin = new financial();
            fin.stock_id = int.Parse(TickerComboBox.SelectedValue.ToString());
            fin.financial_date = FinancialDateTimePicker.Value;
            fin.asset = decimal.Parse(AssetTextBox.Text.Trim());
            fin.liabilities = decimal.Parse(LiabilitiesTextBox.Text.Trim());
            fin.sales = decimal.Parse(SalesTextBox.Text.Trim());
            fin.equity = decimal.Parse(EquityTextBox.Text.Trim());
            fin.gross_profit = decimal.Parse(GrossProfitTextBox.Text.Trim());
            fin.net_income = decimal.Parse(NetIncomeTextBox.Text.Trim());
            fin.cash_flow = decimal.Parse(CashFlowTextBox.Text.Trim());
            return fin;
        }

        private bool CheckFinancialDate(int stock_id, DateTime date)
        {
            return this.financialRepo.CheckStockFinancialMonth(stock_id, date);
        }

        private bool ValidateInput()
        {
            bool success = true;
            if(TickerComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please choose stock ticker");
                success = false;
            }
            else if (String.IsNullOrEmpty(TickerComboBox.Text))
            {
                MessageBox.Show("Please choose stock ticker");
                success = false;
            }
            else if (TickerComboBox.Text.Length != 4)
            {
                MessageBox.Show("Please put 4 characters for stock ticker");
                success = false;
            }

            if (String.IsNullOrEmpty(AssetTextBox.Text.Trim()) ||
                String.IsNullOrEmpty(LiabilitiesTextBox.Text.Trim()) ||
                String.IsNullOrEmpty(SalesTextBox.Text.Trim()) ||
                String.IsNullOrEmpty(EquityTextBox.Text.Trim()) ||
                String.IsNullOrEmpty(GrossProfitTextBox.Text.Trim()) ||
                String.IsNullOrEmpty(NetIncomeTextBox.Text.Trim()) ||
                String.IsNullOrEmpty(CashFlowTextBox.Text.Trim())
                )
            {
                MessageBox.Show("Please input these data");
                success = false;
            }
            return success;
        }

        private void TickerComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            TickerComboBox.DroppedDown = false;
        }

        private void ClearFields()
        {
            AssetTextBox.Text = "";
            LiabilitiesTextBox.Text = "";
            SalesTextBox.Text = "";
            EquityTextBox.Text = "";
            GrossProfitTextBox.Text = "";
            NetIncomeTextBox.Text = "";
            CashFlowTextBox.Text = "";
        }
    }
}
