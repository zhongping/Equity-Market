using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Equity.Repository;
using Equity.Model;
using Equity.View;
using Microsoft.Office.Interop.Excel;

namespace Equity.Helper
{
    class FileHelper
    {

        // =========================== Holding File Function =========================
        
        public static void UploadHoldingFile() {
            
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Read Stock Holding File";
            fileDialog.Filter = "TXT files|*.txt";
            fileDialog.InitialDirectory = @"C:\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadHoldingFile(fileDialog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : Could not read file from disk. " + ex.Message);
                }

            }
        }

        public static void ReadHoldingFile(OpenFileDialog fileDialog)
        {
            EquityRepository equityRepo = new EquityRepository();
            StockRepository stockRepo = new StockRepository();
            equity_holding equity = new equity_holding();
            AwaitForm waitForm = new AwaitForm();
            Stream stream = null;
            String ErrorMessage;
            if ((stream = fileDialog.OpenFile()) != null)
            {
                using (stream)
                {
                  //  string ErrorMessage;
                    string filename = fileDialog.FileName;
                    string[] fileLines = File.ReadAllLines(filename);
                    
                    char[] delimiters = {'|'};
                    bool checkMonth = CheckCurrentMonth(fileLines, equityRepo, delimiters);
                    if (checkMonth == false)
                    {
                        bool success = false;
                        bool flag = true;
                        for (int i = 1; i < fileLines.Length; i++)
                        {
                            string[] words = fileLines[i].Split(delimiters);
                            DateTime date = DateTime.Parse(words[0]);
                           
                            if (words[1].Length == 4)
                            {
                                if (words[2] == "EQUITY")
                                {
                                    string stockCode = words[1].ToUpper().Trim();
                                    bool isExisted = stockRepo.CheckCurrentStock(stockCode);
                                    if (!isExisted)
                                    {
                                        stock stock = new stock();
                                        stock.code = stockCode;
                                        equity.stock_id = stockRepo.SaveStock(stock, out ErrorMessage);
                                    }
                                    equity.stock_id = CheckStockCode(stockRepo, stockCode);
                                    equity.Code = words[1];
                                    equity.Date = date;
                                    equity.Price = Decimal.Parse(words[4]);
                                    equity.Domestic_Insurance = Decimal.Parse(words[5]);
                                    equity.Domestic_Company = Decimal.Parse(words[6]);
                                    equity.Domestic_Pension_Fund = Decimal.Parse(words[7]);
                                    equity.Domestic_Bank = Decimal.Parse(words[8]);
                                    equity.Domestic_Individual = Decimal.Parse(words[9]);
                                    equity.Domestic_Mutual_Fund = Decimal.Parse(words[10]);
                                    equity.Domestic_Security = Decimal.Parse(words[11]);
                                    equity.Domestic_Foundation = Decimal.Parse(words[12]);
                                    equity.Domestic_Others = Decimal.Parse(words[13]);

                                    equity.Foreign_Insurance = Decimal.Parse(words[15]);
                                    equity.Foreign_Company = Decimal.Parse(words[16]);
                                    equity.Foreign_Pension_Fund = Decimal.Parse(words[17]);
                                    equity.Foreign_Bank = Decimal.Parse(words[18]);
                                    equity.Foreign_Individual = Decimal.Parse(words[19]);
                                    equity.Foreign_Mutual_Fund = Decimal.Parse(words[20]);
                                    equity.Foreign_Security = Decimal.Parse(words[21]);
                                    equity.Foreign_Foundation = Decimal.Parse(words[22]);
                                    equity.Foreign_Others = Decimal.Parse(words[23]);

                                    success = equityRepo.SaveEquity(equity, out ErrorMessage);
                                    if (!String.IsNullOrEmpty(ErrorMessage))
                                    {
                                        MessageBox.Show(ErrorMessage);
                                    }
                                    if (flag)
                                    {
                                        waitForm.Show();
                                        waitForm.Refresh();
                                    }
                                }
                            }
                            flag = false;
                        }
                        if (success)
                        {
                            waitForm.Close();
                            MessageBox.Show("Data berhasil disimpan");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data untuk bulan ini telah tersedia");
                    }
                }
            }
        }

        // ======================== Quote File Function ===========================

        public static void UploadQuoteFile(DateTime date)
        {
            OpenFileDialog fileDialog = InitializedFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadQuoteFile(fileDialog, date);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : Could not read file from disk. " + ex.Message);
                }

            }
        }

        private static void FileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OpenFileDialog fileDialog = sender as OpenFileDialog;
            string selectedFile = fileDialog.FileName;
            if (string.IsNullOrEmpty(selectedFile) || selectedFile.Contains(".lnk"))
            {
                MessageBox.Show("Please select a valid Excel file");
                e.Cancel = true;
            }
            return;
        }

        public static void ReadQuoteFile(OpenFileDialog fileDialog, DateTime date)
        {
            StockRepository stockRepo = new StockRepository();
            StockQuoteRepository quoteRepo = new StockQuoteRepository();
            stock_quotes quote = new stock_quotes();
            bool success = false;
            bool flag = true;
            String ErrorMessage;
            AwaitForm waitForm = new AwaitForm();
            string fileName = fileDialog.FileName;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            bool checkDate = quoteRepo.CheckEquityMonth(date.Date);
            if (!checkDate)
            {
                if (xlRange[2, 2].Value2 != null)
                {
                    for (int i = 2; i <= rowCount; i++)
                    {
                        string stockCode = xlRange[i, 1].Value2.ToString().ToUpper().Trim();
                        if (stockCode.Length == 4)
                        {
                            bool isExisted = stockRepo.CheckCurrentStock(stockCode);
                            if (!isExisted)
                            {
                                stock stock = new stock();
                                stock.code = stockCode;
                                quote.stock_id = stockRepo.SaveStock(stock, out ErrorMessage);
                            }
                            quote.stock_id = stockRepo.GetStockId(stockCode);
                            quote.quote_date = date;
                            quote.open = xlRange.Cells[i, 3].Value2 == 0 ? Decimal.Parse(xlRange.Cells[i, 2].Value2.ToString()) : Decimal.Parse(xlRange.Cells[i, 3].Value2.ToString());
                            quote.high = Decimal.Parse(xlRange.Cells[i, 4].Value2.ToString());
                            quote.low = Decimal.Parse(xlRange.Cells[i, 5].Value2.ToString());
                            quote.close = Decimal.Parse(xlRange.Cells[i, 6].Value2.ToString());
                            quote.volume = Decimal.Parse(xlRange.Cells[i, 7].Value2.ToString()) / 100;
                            quote.value = Decimal.Parse(xlRange.Cells[i, 8].Value2.ToString());
                            quote.frequency = Decimal.Parse(xlRange.Cells[i, 9].Value2.ToString());
                            quote.foreign_sell = Decimal.Parse(xlRange.Cells[i, 10].Value2.ToString()) / 100;
                            quote.foreign_buy = Decimal.Parse(xlRange.Cells[i, 11].Value2.ToString()) / 100;

                            success = quoteRepo.SaveStockQuote(quote, out ErrorMessage);
                            if (!String.IsNullOrEmpty(ErrorMessage))
                            {
                                MessageBox.Show(ErrorMessage);
                            }
                            if (flag)
                            {
                                waitForm.Show();
                                waitForm.Refresh();
                            }

                            flag = false;
                        }
                    }
                    if (success)
                    {
                        waitForm.Close();
                        MessageBox.Show("Data berhasil disimpan");
                    }
                }
                else
                {
                    MessageBox.Show("File tidak memiliki data");
                }
            }
            else
            {
                MessageBox.Show("Data untuk tanggal ini telah tersedia");
            }
        }

        public static void EditStockQuoteFile(DateTime date)
        {
            OpenFileDialog fileDialog = InitializedFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    EditQuoteFile(fileDialog, date);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : Could not read file from disk. " + ex.Message);
                }

            }
        }

        public static void EditQuoteFile(OpenFileDialog fileDialog, DateTime date)
        {
            StockQuoteRepository quoteRepo = new StockQuoteRepository();
            StockRepository stockRepo = new StockRepository();
            stock_quotes quote;
            bool success = false;
            bool flag = true;
            String ErrorMessage;
            AwaitForm waitForm = new AwaitForm();
            string fileName = fileDialog.FileName;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
                if (xlRange[2, 2].Value2 != null)
                {
                    for (int i = 2; i <= rowCount; i++)
                    {
                        
                        string stockCode = xlRange[i, 1].Value2.ToString().ToUpper().Trim();
                        int stock_id = stockRepo.GetStockId(stockCode);
                        if (stockCode.Length == 4)
                        {
                            bool isExisted = stockRepo.CheckCurrentStock(stockCode);
                            if (!isExisted)
                            {
                                stock stock = new stock();
                                stock.code = stockCode;
                                quote = new stock_quotes();
                                quote.stock_id = stockRepo.SaveStock(stock, out ErrorMessage);
                            }

                            quote = quoteRepo.FindStockQuoteByStockIdAndDate(stock_id, date);
                            quote.quote_date = date.Date;
                            quote.open = xlRange.Cells[i, 3].Value2 == 0 ? Decimal.Parse(xlRange.Cells[i, 2].Value2.ToString()) : Decimal.Parse(xlRange.Cells[i, 3].Value2.ToString());
                            quote.high = Decimal.Parse(xlRange.Cells[i, 4].Value2.ToString());
                            quote.low = Decimal.Parse(xlRange.Cells[i, 5].Value2.ToString());
                            quote.close = Decimal.Parse(xlRange.Cells[i, 6].Value2.ToString());
                            quote.volume = Decimal.Parse(xlRange.Cells[i, 7].Value2.ToString()) / 100;
                            quote.value = Decimal.Parse(xlRange.Cells[i, 8].Value2.ToString());
                            quote.frequency = Decimal.Parse(xlRange.Cells[i, 9].Value2.ToString());
                            quote.foreign_sell = Decimal.Parse(xlRange.Cells[i, 10].Value2.ToString()) / 100;
                            quote.foreign_buy = Decimal.Parse(xlRange.Cells[i, 11].Value2.ToString()) / 100;

                            success = quoteRepo.UpdateStockQuote(quote, out ErrorMessage);
                            if (!String.IsNullOrEmpty(ErrorMessage))
                            {
                                MessageBox.Show(ErrorMessage);
                            }
                            if (flag)
                            {
                                waitForm.Show();
                                waitForm.Refresh();
                            }

                            flag = false;
                        }
                    }
                    if (success)
                    {
                        waitForm.Close();
                        MessageBox.Show("Data berhasil disimpan");
                    }
                }
                else
                {
                    MessageBox.Show("File tidak memiliki data");
                }
        }

            // ======================== Utility Function ==============================

        private static OpenFileDialog InitializedFileDialog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Read Stock Quote File";
            fileDialog.Filter = "Excel files |*.xls; *.xlsx";
            fileDialog.InitialDirectory = @"C:\";
            fileDialog.Multiselect = false;
            fileDialog.ValidateNames = true;
            fileDialog.DereferenceLinks = false;
            fileDialog.FileOk += FileDialog_FileOk;
            return fileDialog;
        }
        
        private static bool CheckCurrentMonth(string[] fileLines, EquityRepository equityRepo, char[] delimiters)
        {
            bool isExisted = true;
            string[] words = fileLines[1].Split(delimiters);
            DateTime date = DateTime.Parse(words[0]);
            if (equityRepo.CheckEquityMonth(date) == false)
            {
                isExisted = false;
            }
            return isExisted;
        }

        private static int CheckStockCode(StockRepository stockRepo, string code)
        {
            int stock_id = stockRepo.GetStockId(code);
            return stock_id;
        }

        private void CheckFileFormat()
        {

        }
    }
}
