//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrownsIntranetApps.Entity.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceService()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int ID { get; set; }
        public string ServicedAt { get; set; }
        public System.DateTime ServiceStartDate { get; set; }
        public System.DateTime ServiceEndDate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string UnitNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}