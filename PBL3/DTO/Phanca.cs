//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phanca
    {
        public int idPhanca { get; set; }
        public Nullable<int> idShift { get; set; }
        public Nullable<int> idAccount { get; set; }
        public string Daywork { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Calam Calam { get; set; }
    }
}
