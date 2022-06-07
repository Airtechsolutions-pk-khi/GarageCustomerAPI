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
    
    public partial class sp_GetCarHistory_CAPP_Result
    {
        public int OrderID { get; set; }
        public Nullable<int> TransactionNo { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public Nullable<int> OrderTakerID { get; set; }
        public Nullable<int> CarID { get; set; }
        public Nullable<int> BayID { get; set; }
        public string OrderType { get; set; }
        public Nullable<double> Points { get; set; }
        public string OrderMode { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> OrderPunchDt { get; set; }
        public Nullable<System.DateTime> OrderCreatedDT { get; set; }
        public string SessionID { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public int LocationID { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> SubUserID { get; set; }
        public Nullable<double> CheckLiters { get; set; }
        public Nullable<double> NextKM { get; set; }
        public int OrderCheckOutID { get; set; }
        public int OrderID1 { get; set; }
        public string SessionId1 { get; set; }
        public string CheckoutDate { get; set; }
        public Nullable<double> AmountTotal { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public Nullable<double> AmountPaid { get; set; }
        public Nullable<double> AmountDiscount { get; set; }
        public Nullable<double> Tax { get; set; }
        public Nullable<double> GrandTotal { get; set; }
        public string lastUpdateBy1 { get; set; }
        public Nullable<System.DateTime> LastUpdateDT1 { get; set; }
        public string Remarks { get; set; }
        public int LocationID1 { get; set; }
        public Nullable<double> AmountComplementary { get; set; }
        public Nullable<System.DateTime> CreatedOn1 { get; set; }
        public string CreatedBy1 { get; set; }
        public Nullable<int> WorkerID { get; set; }
        public Nullable<int> AssistantID { get; set; }
        public Nullable<int> PaymentMode { get; set; }
        public Nullable<int> SubUserID1 { get; set; }
        public Nullable<double> RefundedAmount { get; set; }
        public Nullable<double> CashReturn { get; set; }
        public Nullable<double> CardReturn { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<bool> IsReady { get; set; }
        public Nullable<int> Gratuity { get; set; }
        public Nullable<double> ServiceCharges { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public Nullable<double> TaxPercent { get; set; }
        public Nullable<int> CreditCustomerID { get; set; }
        public Nullable<double> PartialAmountReceived { get; set; }
        public Nullable<bool> IsPartialPaid { get; set; }
        public string DiscountCode { get; set; }
        public Nullable<System.DateTime> OrderPunchDate { get; set; }
        public string MechanicName { get; set; }
    }
}
