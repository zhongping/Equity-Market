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
    class EquityRepository
    {
        idx_equityEntities entities;
        StockRepository stockRepo;

        public EquityRepository()
        {
            entities = new idx_equityEntities();
            stockRepo = new StockRepository();
        }

        public bool CheckEquityMonth(DateTime date)
        {
            bool isChecked = entities.equity_holding.Where(q => q.Date == date).Count() > 0;
            return isChecked;
        }

        public bool SaveEquity(equity_holding equity_holding, out string errorMessage)
        {
            bool success = true;
            errorMessage = String.Empty;
            try
            {
                entities.equity_holding.Add(equity_holding);
                entities.SaveChanges();
            }
            catch (Exception e) {
                Console.WriteLine(e.InnerException.Message.ToString());
                errorMessage = e.InnerException.InnerException.Message;
                success = false;
            }
            return success;
        }

        public equity_holding LoadEquity(string stock)
        {
            equity_holding equity = entities.equity_holding.Where(q => q.Code == stock).FirstOrDefault();
            return equity;
        }

        public List<equity_holding> LoadEquityList(string stock, DateTime From, DateTime To)
        {
            var EndMonth = To.AddMonths(1);
            List<equity_holding> equityList = entities.equity_holding.Where(q => q.Code == stock).Where(r => r.Date > From && r.Date < EndMonth).ToList();
            return equityList;
        }

        public equity_holding MonthlyLoadEquity(string stock, DateTime date)
        {
            equity_holding equity = entities.equity_holding.Where(q => q.Code == stock).Where(s => s.Date.Year == date.Year && s.Date.Month == date.Month).FirstOrDefault();
            return equity;
        }

        public List<total_composition> LoadTotalHolding(string stock, DateTime From, DateTime To)
        {
            var EndMonth = To.AddMonths(1);
            List<total_composition> equityList = entities.total_composition.Where(q => q.code == stock).Where(r => r.date > From && r.date < EndMonth).OrderBy(d => d.date).ToList();
            return equityList;
        }

        public List<domestic_individual> GetIndividualHolding(string code)
        {
            var code_parameter = new MySqlParameter("@code", code);
            List<domestic_individual> net_buy = entities.Database.SqlQuery<domestic_individual>("CALL get_domestic_foreign_individual_holding(@code)", code_parameter).ToList();
            return net_buy;
        }

        public void Dispose()
        {
            this.entities.Dispose();
        }
    }
}
