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
    
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.Bills = new HashSet<Bill>();
        }
    
        public int idAccount { get; set; }
        public string DisplayName { get; set; }
        public Nullable<bool> GT { get; set; }
        public string SDT { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Calam { get; set; }
        public int Type { get; set; }
        public byte[] anh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}