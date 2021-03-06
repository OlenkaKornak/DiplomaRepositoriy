//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkOfFund.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Child
    {
        public int child_id { get; set; }
        public string child_name { get; set; }
        public string child_surname { get; set; }
        public string child_baccount { get; set; }
        public Nullable<int> child_budget { get; set; }
        public string child_phone { get; set; }
        public string child_description { get; set; }
        public Nullable<int> child_price { get; set; }
        public int cfund_id { get; set; }
        public Nullable<int> cclinic_id { get; set; }
        public int cdiagnosis_id { get; set; }
        public int cpriority_id { get; set; }
        public int cstatus_id { get; set; }
        public int cdatebirth_id { get; set; }
        public int cdatedeadline_id { get; set; }
    
        public virtual Clinic Clinic { get; set; }
        public virtual MyDate MyDate { get; set; }
        public virtual MyDate MyDate1 { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
        public virtual Fund Fund { get; set; }
        public virtual MyPriority MyPriority { get; set; }
        public virtual MyStatus MyStatus { get; set; }
    }
}
