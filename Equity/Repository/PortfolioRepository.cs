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
    class PortfolioRepository
    {
        idx_equityEntities entities;
        StockRepository stockRepo;
        TransactionRepository transactionRepo;

        public PortfolioRepository()
        {
            entities = new idx_equityEntities();
            stockRepo = new StockRepository();
            transactionRepo = new TransactionRepository();
        }

        public bool SavePortfolio(transaction transaction, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                portfolio portfolio = new portfolio();
                portfolio.total_shares = transaction.number_of_shares;
                portfolio.average_price = transaction.transaction_price;
                entities.portfolios.Add(portfolio);
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
