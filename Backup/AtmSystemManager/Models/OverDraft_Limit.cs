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
    
    public partial class OverDraft_Limit
    {
        public OverDraft_Limit()
        {
            this.Accounts = new HashSet<Account>();
        }
    
        public int ODID { get; set; }
        public decimal Value { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
    }
}