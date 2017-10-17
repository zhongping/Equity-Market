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
    class TransactionRepository
    {
        idx_equityEntities entities;
        StockRepository stockRepo;
        PortfolioRepository portfolioRepo;

        public TransactionRepository()
        {
            entities = new idx_equityEntities();
            stockRepo = new StockRepository();
            portfolioRepo = new PortfolioRepository();
        }

        public bool SaveTransaction(transaction transaction, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                entities.transactions.Add(transaction);
                entities.SaveChanges();
                this.portfolioRepo.SavePortfolio(transaction, out errorMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message.ToString());
                errorMessage = e.InnerException.InnerException.Message;
                success = false;
            }
            return success;
        }

        public bool UpdateTransaction(transaction transaction, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                entities.Entry(transaction).State = EntityState.Modified;
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
