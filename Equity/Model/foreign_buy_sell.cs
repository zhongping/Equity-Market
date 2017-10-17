using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equity.Model
{
    class foreign_buy_sell
    {
        public string code { get; set; }

        public DateTime quote_date { get; set; }

        public decimal foreign_buy { get; set; }

        public decimal foreign_sell { get; set; }

        public decimal foreign_net_buy { get; set; }
    }
}
