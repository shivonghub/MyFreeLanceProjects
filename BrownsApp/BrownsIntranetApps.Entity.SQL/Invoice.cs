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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.InvoiceLabors = new HashSet<InvoiceLabor>();
            this.InvoiceItems = new HashSet<InvoiceItem>();
        }
    
        public int ID { get; set; }
        public string InvoiceType { get; set; }
        public int CustomerID { get; set; }
        public string InvoiceNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string OrderNumber { get; set; }
        public string ShippingMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string CustomerPO { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public decimal Total { get; set; }
        public Nullable<decimal> BalanceDue { get; set; }
        public string Comments { get; set; }
        public Nullable<decimal> TravelCharge { get; set; }
        public Nullable<decimal> TravelExpense { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public string AddedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string SaleRep { get; set; }
        public Nullable<decimal> PartsSubTotal { get; set; }
        public Nullable<decimal> LaborSubTotal { get; set; }
        public string InvoiceStatus { get; set; }
        public Nullable<int> InvoiceStatusID { get; set; }
        public Nullable<int> ShippingMethodID { get; set; }
        public Nullable<int> PaymentStatusID { get; set; }
        public Nullable<int> InvoiceServiceID { get; set; }
        public string County { get; set; }
        public Nullable<bool> IsStorePickUp { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public Nullable<int> CountyId { get; set; }
    
        public virtual Invoice Invoice1 { get; set; }
        public virtual Invoice Invoice2 { get; set; }
        public virtual InvoiceService InvoiceService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceLabor> InvoiceLabors { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
