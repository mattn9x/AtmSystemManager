//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtmSystemManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int StockID { get; set; }
        public int MoneyID { get; set; }
        public int ATMID { get; set; }
        public int Quantity { get; set; }
    
        public virtual ATM ATM { get; set; }
        public virtual Money Money { get; set; }
    }
}
