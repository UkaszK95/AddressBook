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
    
    public partial class Addresses
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string phoneNumber { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> city { get; set; }
        public Nullable<System.DateTime> dateOfCreation { get; set; }
        public Nullable<System.DateTime> dateOfUpdate { get; set; }
    
        public virtual Cities Cities { get; set; }
    }
}