//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Equity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class transaction
    {
        public int id { get; set; }
        public Nullable<int> stock_id { get; set; }
        public Nullable<System.DateTime> transaction_date { get; set; }
        public Nullable<decimal> number_of_shares { get; set; }
        public string transaction_type { get; set; }
        public Nullable<decimal> transaction_price { get; set; }
        public Nullable<decimal> transaction_fee { get; set; }
        public Nullable<int> portfolio_id { get; set; }
        public Nullable<int> broker_id { get; set; }
    
        public virtual portfolio portfolio { get; set; }
        public virtual stock stock { get; set; }
        public virtual broker broker { get; set; }
    }
}