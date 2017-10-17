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
using Equity.Helper;
using Equity.Model;

namespace Equity.View.Portfolio
{
    public partial class CreateTransactionForm : Form
    {
        StockRepository stockRepo;
        BrokerRepository brokerRepo;
        TransactionRepository transactionRepo;

        public CreateTransactionForm()
        {
            InitializeComponent();
            stockRepo = new StockRepository();
            brokerRepo = new BrokerRepository();
            transactionRepo = new TransactionRepository();
        }

        private void CreateTransactionForm_Load(object sender, EventArgs e)
        {
            DataHelper.LoadTickerComboBox(stockRepo, TickerComboBox);
            DataHelper.LoadBrokerComboBox(brokerRepo, BrokerComboBox);
        }

        private void SharesNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void TransactionPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please input numeric only");
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            bool validated = this.ValidateInput();
            if(validated)
            {
                this.ProcessTransaction();
            }
        }

        private void ProcessTransaction()
        {
            string message = String.Empty;
            transaction transaction = this.PopulateTransaction();
            bool success = this.transactionRepo.SaveTransaction(transaction, out message);
            if (success)
            {
                MessageBox.Show("Transaction has been recorded");
            }
        }

        private transaction PopulateTransaction()
        {
            transaction transaction = new transaction();
            transaction.stock_id =  int.Parse(TickerComboBox.SelectedValue.ToString());
            transaction.transaction_date = TransactionDateTimePicker.Value;
            transaction.number_of_shares = decimal.Parse(SharesNumberTextBox.Text.Trim());
            transaction.transaction_price = decimal.Parse(TransactionPriceTextBox.Text.Trim());
            transaction.broker_id = int.Parse(BrokerComboBox.SelectedValue.ToString());
            transaction.transaction_type = BuyRadioButton.Checked ? BuyRadioButton.Text : SellRadioButton.Text;
            transaction.transaction_fee = this.brokerRepo.getTransactionFee(transaction.transaction_type, transaction.broker_id);
            return transaction;
        }

        private bool ValidateInput()
        {
            bool success = true;
            if (TickerComboBox.SelectedValue == null)
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

            if (BrokerComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please choose broker");
                success = false;
            }
            else if (String.IsNullOrEmpty(BrokerComboBox.Text))
            {
                MessageBox.Show("Please choose broker");
                success = false;
            }

            if (String.IsNullOrEmpty(SharesNumberTextBox.Text.Trim()) ||
                String.IsNullOrEmpty(TransactionPriceTextBox.Text.Trim())
                )
            {
                MessageBox.Show("Please input these data");
                success = false;
            }

            if (!BuyRadioButton.Checked && !SellRadioButton.Checked)
            {
                MessageBox.Show("Please choose transaction type");
                success = false;
            }

            return success;
        }

        private void TickerComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            TickerComboBox.DroppedDown = false;
        }

        private void BrokerComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            BrokerComboBox.DroppedDown = false;
        }

        private void ClearFields()
        {
            SharesNumberTextBox.Text = "";
            TransactionPriceTextBox.Text = "";
        }

      
    }
}
