//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3._1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public string idBill { get; set; }
        public string Customer { get; set; }
        public Nullable<System.DateTime> paymenttime { get; set; }
        public Nullable<bool> thanhtoan { get; set; }
        public int idTable { get; set; }
        public string orderedDrink { get; set; }
        public int idAccount { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual TableFood TableFood { get; set; }
    }
}
