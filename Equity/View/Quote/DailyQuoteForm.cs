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
    public partial class DailyQuoteForm : Form
    {
        StockQuoteRepository quoteRepo;
        StockRepository stockRepo;
        stock stock;

        public DailyQuoteForm()
        {
            InitializeComponent();
            quoteRepo = new StockQuoteRepository();
            stockRepo = new StockRepository();
        }

        private void DailyQuoteForm_Load(object sender, EventArgs e)
        {
            StockQuoteLabel.Text = "";
            StockNameLabel.Text = "";
        }

        private void QuoteSearchButton_Click(object sender, EventArgs e)
        {
            string stockCode = QuoteSearchTextBox.Text.ToUpper().Trim();
            stock = this.stockRepo.GetStockByCode(stockCode);
            StockQuoteLabel.Text = stock.code;
            StockNameLabel.Text = stock.name;
            this.DailyQuoteDataGridView.DataSource = this.quoteRepo.GetStockQuoteByCode(stockCode);
        }
    }
}
