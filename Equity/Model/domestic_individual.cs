using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equity.Model
{
    class domestic_individual
    {
        public DateTime date { get; set; }

        public string code { get; set; }

        public decimal Domestic_Individual { get; set; }

        public decimal foreign_non_individual { get; set; }
    }
}
