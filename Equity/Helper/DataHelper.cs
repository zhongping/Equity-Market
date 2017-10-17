using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equity.Repository;
using System.Windows.Forms;

namespace Equity.Helper
{
    class DataHelper
    {
        public static void LoadTickerComboBox(StockRepository stockRepo, ComboBox TickerComboBox)
        {
            TickerComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TickerComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            TickerComboBox.DataSource = stockRepo.GetStockList();
            TickerComboBox.DisplayMember = "code";
            TickerComboBox.ValueMember = "id";
        }

        public static void LoadBrokerComboBox(BrokerRepository brokerRepo, ComboBox BrokerComboBox)
        {
            BrokerComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BrokerComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            BrokerComboBox.DataSource = brokerRepo.GetBrokerList();
            BrokerComboBox.DisplayMember = "name";
            BrokerComboBox.ValueMember = "id";
        }
    }
}
