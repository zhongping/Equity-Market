using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equity.Model
{
    class code_stock_quote
    {
        public DateTime quote_date { get; set; }

        public decimal open { get; set; }

        public decimal high { get; set; }

        public decimal low { get; set; }

        public decimal close { get; set; }

        public decimal volume { get; set; }

        public decimal value { get; set; }

        public decimal foreign_buy { get; set; }

        public decimal foreign_sell { get; set; }
    }
}
