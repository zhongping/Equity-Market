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
    class BrokerRepository
    {
        idx_equityEntities entities;
        StockRepository stockRepo;

        public BrokerRepository()
        {
            entities = new idx_equityEntities();
            stockRepo = new StockRepository();
        }

        public broker GetBrokerById(int? brokerId)
        {
            broker broker = entities.brokers.Where(q => q.id == brokerId).FirstOrDefault();
            return broker;
        }

        public List<broker> GetBrokerList()
        {
            List<broker> brokerList = entities.brokers.ToList();
            return brokerList;
        }

        public decimal? getTransactionFee(string transactionType, int? brokerId)
        {
            broker broker = this.GetBrokerById(brokerId);
            decimal? transactionFee = transactionType == "Buy" ? broker.buy_fee : broker.sell_fee;
            return transactionFee;
        }

        public void Dispose()
        {
            this.entities.Dispose();
        }

    }
}
