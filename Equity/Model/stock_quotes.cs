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
    
    public partial class stock_quotes
    {
        public int id { get; set; }
        public Nullable<int> stock_id { get; set; }
        public System.DateTime quote_date { get; set; }
        public Nullable<decimal> open { get; set; }
        public Nullable<decimal> high { get; set; }
        public Nullable<decimal> low { get; set; }
        public Nullable<decimal> close { get; set; }
        public Nullable<decimal> volume { get; set; }
        public Nullable<decimal> frequency { get; set; }
        public Nullable<decimal> value { get; set; }
        public Nullable<decimal> foreign_buy { get; set; }
        public Nullable<decimal> foreign_sell { get; set; }
    
        public virtual stock stock { get; set; }
    }
}