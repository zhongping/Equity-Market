using System;
using System.Windows.Forms;
using Equity.Helper;
using Equity.View;
using Equity.View.Quote;
using Equity.View.Quote.Analysis;
using Equity.View.Fundamental;
using Equity.View.Holding;
using Equity.View.Portfolio;

namespace Equity
{
    public partial class MainForm : Form
    {
        StockChartForm chartForm;
        StockDataForm stockForm;
        StockChartTimeBasedForm stockTimeBasedForm;
        StockChartTotalForm totalForm;
        DomesticIndividualForm domesticIndividualForm;
        DailyQuoteForm dailyQuoteForm;
        QuoteChartForm quoteChartForm;
        ForeignChartForm foreignChartForm;
        InsertFinancialReportForm insertFinancialReportForm;
        DailyForeignNetBuyChartForm dailyForeignNetBuyChartForm;
        CreateTransactionForm createTransactionForm;

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
        }

//========================= Holding Stock ============================


        private void uploadFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileHelper.UploadHoldingFile();
        }

        private void dataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stockForm == null)
            {
                stockForm = new StockDataForm();
                this.IsMdiContainer = true;
                stockForm.MdiParent = this;
                MainPanel.Visible = false;
                stockForm.FormClosed += StockForm_FormClosed;
                stockForm.Show();
            }
            else
            {
                stockForm.Activate();
            }
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chartForm == null)
            {
                chartForm = new StockChartForm();
                this.IsMdiContainer = true;
                chartForm.MdiParent = this;
                MainPanel.Visible = false;
                chartForm.FormClosed += ChartForm_FormClosed;
                chartForm.Show();
            }
            else
            {
                chartForm.Activate();
            }
        }

        private void timeBasedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stockTimeBasedForm == null)
            {
                stockTimeBasedForm = new StockChartTimeBasedForm();
                this.IsMdiContainer = true;
                stockTimeBasedForm.MdiParent = this;
                MainPanel.Visible = false;
                stockTimeBasedForm.FormClosed += StockTimeBasedForm_FormClosed;
                stockTimeBasedForm.Show();
            }
            else
            {
                stockTimeBasedForm.Activate();
            }
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (totalForm == null)
            {
                totalForm = new StockChartTotalForm();
                this.IsMdiContainer = true;
                totalForm.MdiParent = this;
                MainPanel.Visible = false;
                totalForm.FormClosed += TotalForm_FormClosed;
                totalForm.Show();
            }
            else
            {
                totalForm.Activate();
            }
        }

        private void individualVsNonIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (domesticIndividualForm == null)
            {
                domesticIndividualForm = new DomesticIndividualForm();
                this.IsMdiContainer = true;
                domesticIndividualForm.MdiParent = this;
                MainPanel.Visible = false;
                domesticIndividualForm.FormClosed += DomesticIndividualForm_FormClosed;
                domesticIndividualForm.Show();
            }
            else
            {
                domesticIndividualForm.Activate();
            }
        }

        private void TotalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            totalForm = null;
        }

        private void StockTimeBasedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stockTimeBasedForm = null;
        }

         private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stockForm = null;
        }

        private void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            chartForm = null;
        }

        private void DomesticIndividualForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            domesticIndividualForm = null;
        }

        // =========================== Stock Quote =================================

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadQuoteForm quoteForm = new UploadQuoteForm();
            quoteForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditQuoteForm editQuoteForm = new EditQuoteForm();
            editQuoteForm.Show();
        }

        private void stockChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quoteChartForm == null)
            {
                quoteChartForm = new QuoteChartForm();
                this.IsMdiContainer = true;
                quoteChartForm.MdiParent = this;
                MainPanel.Visible = false;
                quoteChartForm.FormClosed += QuoteChartForm_FormClosed;
                quoteChartForm.Show();
            }
            else
            {
                dailyQuoteForm.Activate();
            }
        }

        private void quoteDataDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dailyQuoteForm == null)
            {
                dailyQuoteForm = new DailyQuoteForm();
                this.IsMdiContainer = true;
                dailyQuoteForm.MdiParent = this;
                MainPanel.Visible = false;
                dailyQuoteForm.FormClosed += DailyQuoteForm_FormClosed; 
                dailyQuoteForm.Show();
            }
            else
            {
                dailyQuoteForm.Activate();
            }
        }

        private void foreignPositionChartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (foreignChartForm == null)
            {
                foreignChartForm = new ForeignChartForm();
                this.IsMdiContainer = true;
                foreignChartForm.MdiParent = this;
                MainPanel.Visible = false;
                foreignChartForm.FormClosed += ForeignChartForm_FormClosed;
                foreignChartForm.Show();
            }
            else
            {
                foreignChartForm.Activate();
            }
        }

        private void dailyForeignNetBuyChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dailyForeignNetBuyChartForm == null)
            {
                dailyForeignNetBuyChartForm = new DailyForeignNetBuyChartForm();
                this.IsMdiContainer = true;
                dailyForeignNetBuyChartForm.MdiParent = this;
                MainPanel.Visible = false;
                dailyForeignNetBuyChartForm.FormClosed += DailyForeignNetBuyChartForm_FormClosed;
                dailyForeignNetBuyChartForm.Show();
            }
            else
            {
                dailyForeignNetBuyChartForm.Activate();
            }
        }

        private void DailyForeignNetBuyChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dailyForeignNetBuyChartForm = null;
        }

        private void DailyQuoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dailyQuoteForm = null;
        }

        private void QuoteChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            quoteChartForm = null;
        }

        private void ForeignChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreignChartForm = null;
        }


        // ========================== Fundamental Form =============================

        private void insertFinancialReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (insertFinancialReportForm == null)
            {
                insertFinancialReportForm = new InsertFinancialReportForm();
                this.IsMdiContainer = true;
                insertFinancialReportForm.MdiParent = this;
                MainPanel.Visible = false;
                insertFinancialReportForm.FormClosed += InsertFinancialReportForm_FormClosed;
                insertFinancialReportForm.Show();
            }
            else
            {
                insertFinancialReportForm.Activate();
            }
        }

        private void insertFundamentalRatioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void InsertFinancialReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            insertFinancialReportForm = null;
        }

        // ========================== Portfolio ====================================

        private void createTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createTransactionForm == null)
            {
                createTransactionForm = new CreateTransactionForm();
                this.IsMdiContainer = true;
                createTransactionForm.MdiParent = this;
                MainPanel.Visible = false;
                createTransactionForm.FormClosed += CreateTransactionForm_FormClosed;
                createTransactionForm.Show();
            }
            else
            {
                createTransactionForm.Activate();
            }
        }

        private void CreateTransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            createTransactionForm = null;
        }

        // ========================== General Function =============================

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
