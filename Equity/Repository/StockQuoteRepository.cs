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
    class StockQuoteRepository
    {
        idx_equityEntities entities;

        public StockQuoteRepository()
        {
            entities = new idx_equityEntities();
        }

        public bool CheckEquityMonth(DateTime date)
        {
            bool isChecked = entities.stock_quotes.Where(q => q.quote_date == date).Count() > 0;
            return isChecked;
        }

        public stock_quotes FindStockQuoteById(int id)
        {
            stock_quotes quote = entities.stock_quotes.Where(q => q.id == id).First();
            return quote;
        }

        public List<stock_quotes> FindStockQuoteByStockId(int stock_id)
        {
            List<stock_quotes> quoteList = entities.stock_quotes.Where(q => q.stock_id == stock_id).ToList();
            return quoteList;
        }

        public List<stock_quotes> FindStockQuoteByDate(DateTime date)
        {
            List<stock_quotes> quoteList = entities.stock_quotes.Where(q => q.quote_date == date.Date).ToList();
            return quoteList;
        }

        public stock_quotes FindStockQuoteByStockIdAndDate(int stock_id, DateTime date)
        {
            stock_quotes quote = entities.stock_quotes.Where(q => q.stock_id == stock_id).Where(q => q.quote_date == date.Date).First();
            return quote;
        }

        public List<stock_quotes> LoadStockQuoteByCode(string code)
        {
            List<stock_quotes> quoteList = entities.stock_quotes.Where(q => q.stock.code == code).ToList();
            return quoteList;
        }

        public List<foreign_buy_sell> GetForeignNetBuy(string code)
        {
            var code_parameter = new MySqlParameter("@code", code);
            List<foreign_buy_sell> net_buy = entities.Database.SqlQuery<foreign_buy_sell>("CALL get_foreign_net_buy_by_code(@code)", code_parameter).ToList();
            return net_buy;
        }

        public List<code_stock_quote> GetStockQuoteByCode(string code)
        {
            var code_parameter = new MySqlParameter("@code", code);
            List<code_stock_quote> quoteList = entities.Database.SqlQuery<code_stock_quote>("CALL get_stock_quote_by_code(@code)", code_parameter).ToList();
            return quoteList;
        }

        public List<stock_quotes> GetQuoteListByCode(string code)
        {
            List<stock_quotes> quoteList = entities.stock_quotes.Where(q => q.stock.code == code).ToList();
            return quoteList;
        }

        public bool SaveStockQuote(stock_quotes quote, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                entities.stock_quotes.Add(quote);
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

        public bool UpdateStockQuote(stock_quotes quote, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                entities.Entry(quote).State = EntityState.Modified;
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

        public bool DeleteStockQuote(stock_quotes quote, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                entities.stock_quotes.Remove(quote);
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
