using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equity.Model;
using System.Data.Entity;
using MySql.Data.MySqlClient;

namespace Equity.Repository
{
    class FinancialReportRepository
    {
        idx_equityEntities entities;

        public FinancialReportRepository()
        {
            entities = new idx_equityEntities();
        }

        public bool CheckFinancialMonth(DateTime date)
        {
            bool isChecked = entities.financials.Where(q => q.financial_date == date).Count() > 0;
            return isChecked;
        }

        public bool CheckStockFinancialMonth(int stock_id, DateTime date)
        {
            bool isChecked = entities.financials.Where(q => q.stock_id == stock_id).Where(q => q.financial_date == date).Count() > 0;
            return isChecked;
        }

        public bool SaveFinancialReport(financial financial, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                entities.financials.Add(financial);
                entities.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message.ToString());
                errorMessage = e.InnerException.InnerException.Message;
                success = false;
            }
            return success;
        }

        public void Dispose()
        {
            this.entities.Dispose();
        }
    }
}
