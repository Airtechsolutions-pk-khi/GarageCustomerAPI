//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DBEntities2
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyQuotationDetail
    {
        public int CQuotationDetailID { get; set; }
        public Nullable<int> CompanyQuotationID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemNameArabic { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> TaxRate { get; set; }
        public Nullable<double> TaxAmount { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<int> StatusID { get; set; }
    
        public virtual CompanyQuotation CompanyQuotation { get; set; }
    }
}
