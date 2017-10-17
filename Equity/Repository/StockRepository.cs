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
    class StockRepository
    {
        idx_equityEntities entities;

        public StockRepository()
        {
            entities = new idx_equityEntities();
        }

        public stock GetStockByCode(string code)
        {
            stock stock = entities.stocks.Where(q => q.code == code).FirstOrDefault();
            return stock;
        }

        public int GetStockId(string code)
        {
            int stockid = 0;
            stock stock = entities.stocks.Where(q => q.code == code).FirstOrDefault();
            if (stock != null)
            {
                stockid = stock.id;
            }
            return stockid;
        }

        public stock GetStockById(int id)
        {
            stock stock = entities.stocks.Where(q => q.id == id).First();
            return stock;
        }

        public List<stock> GetStockList()
        {
            List<stock> stockList = entities.stocks.ToList();
            return stockList;
        }

        public int SaveStock(stock stock, out string errorMessage)
        {
            int stockid = 0;
            errorMessage = String.Empty;
            bool isExisted = this.CheckCurrentStock(stock.code);
            if (!isExisted)
            {
                try
                {
                    entities.stocks.Add(stock);
                    entities.SaveChanges();
                    stockid = stock.id;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException.Message.ToString());
                    errorMessage = e.InnerException.InnerException.Message;
                }
            }
            return stockid;
        }

        public bool AddStock(stock stock, out string errorMessage)
        {
            bool success = false;
            errorMessage = String.Empty;
            bool isExisted = this.CheckCurrentStock(stock.code);
            if (!isExisted)
            {
                try
                {
                    entities.stocks.Add(stock);
                    entities.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException.Message.ToString());
                    errorMessage = e.InnerException.InnerException.Message;
                }
            }
            return success;
        }

       

        public bool CheckCurrentStock(string code)
        {
            bool stock_exist = entities.stocks.Where(q => q.code == code).Count() > 0;
            return stock_exist;
        }

        public void Dispose()
        {
            this.entities.Dispose();
        }
    }
}
