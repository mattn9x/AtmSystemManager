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
    
    public partial class ATM
    {
        public ATM()
        {
            this.Logs = new HashSet<Log>();
            this.Stocks = new HashSet<Stock>();
        }
    
        public int ATMID { get; set; }
        public string Branch { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
