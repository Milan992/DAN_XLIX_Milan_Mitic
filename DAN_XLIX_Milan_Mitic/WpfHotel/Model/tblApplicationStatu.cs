//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfHotel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblApplicationStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblApplicationStatu()
        {
            this.tblApplications = new HashSet<tblApplication>();
        }
    
        public int ApplicationStatusID { get; set; }
        public string ApplicationStatusName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblApplication> tblApplications { get; set; }
    }
}
