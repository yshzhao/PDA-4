//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelPOS.ModelEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class view_report_invoice
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string ProductNameDesc { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Total { get; set; }
    }
}
