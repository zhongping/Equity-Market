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
    
    public partial class financial
    {
        public int id { get; set; }
        public Nullable<int> stock_id { get; set; }
        public Nullable<System.DateTime> financial_date { get; set; }
        public Nullable<decimal> asset { get; set; }
        public Nullable<decimal> liabilities { get; set; }
        public Nullable<decimal> sales { get; set; }
        public Nullable<decimal> equity { get; set; }
        public Nullable<decimal> gross_profit { get; set; }
        public Nullable<decimal> net_income { get; set; }
        public Nullable<decimal> cash_flow { get; set; }
    
        public virtual stock stock { get; set; }
    }
}