//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MolkomRecruitmentTask.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cities()
        {
            this.Addresses = new HashSet<Addresses>();
        }
    
        public int id { get; set; }
        public string postalCode { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> dateOfCreation { get; set; }
        public Nullable<System.DateTime> dateOfUpdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
