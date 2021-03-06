using DAL.DBEntities;
using DAL.DBEntities2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPICode.Helpers;

namespace DAL.Models
{
    class ViewModel
    {
    }

    public class Rsp
    {
        public string Description { get; set; }
        public int Status { get; set; }

    }
    public class RspBrandList : Rsp
    {
        public List<BrandsBLL> brands { get; set; }
    }


    public class CarRsp : Rsp
    {
        public Cars cars { get; set; }
    }

    public class RspSetting : Rsp
    {
        public List<LocationsBLL> Settings { get; set; }
        public List<ServiceBLL> Services { get; set; }
    }
    public class AmenitiesBLL
    {
        public int? AmenitiesID{ get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int? LocationID { get; set; }
    }
    public class ReviewsBLL
    {
        public int? ReviewID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Rate { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public int? LocationID { get; set; }
    }
    public class DiscountBLL
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int? LocationID { get; set; }
        public int? DiscountID{ get; set; }
    }
    public class ServiceBLL
    {
        public int ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string Image { get; set; }
        public int? DisplayOrder { get; set; }
        public int? LocationID { get; set; }

    }


    public class RspAppSetting : Rsp
    {
        public AppInfoBLL AppInfo { get; set; }
        public List<AboutBLL> Timings { get; set; }
    }
    public class RspDeliveryAreaList : Rsp
    {
        public List<DeliveryAreaBLL> DeliveryArea { get; set; }
    }
    public class RspAdminLogin : Rsp
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

    }
    public class Invoice
    {
        public string InvoiceNumber { get; set; }
        public int POSID { get; set; }
        public string USIN { get; set; }
        public DateTime DateTime { get; set; }
        public string BuyerName { get; set; }
        public string BuyerNTN { get; set; }
        public string BuyerCNIC { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public double TotalSaleValue { get; set; }
        public double TotalTaxCharged { get; set; }
        public double TotalQuantity { get; set; }
        public double Discount { get; set; }
        public double FurtherTax { get; set; }
        public double TotalBillAmount { get; set; }
        public int PaymentMode { get; set; }

        public int InvoiceType { get; set; }
        public List<InvoiceItems> Items { get; set; }
    }
    public class InvoiceItems
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string PCTCode { get; set; }
        public double Quantity { get; set; }
        public float TaxRate { get; set; }
        public double SaleValue { get; set; }
        public double Discount { get; set; }
        public double FurtherTax { get; set; }
        public double TaxCharged { get; set; }
        public double TotalAmount { get; set; }
        public int InvoiceType { get; set; }
        public string RefUSIN { get; set; }

    }

    public class RspBanners
    {
        public int BannerID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> BrandID { get; set; }

    }
    public class RspOffers
    {
        public int OfferID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string Image { get; set; }
        public string BrandLogo { get; set; }
        public string BrandName { get; set; }
        public string ItemName { get; set; }
        public string Calories { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> StatusID { get; set; }

        public List<LocationsBLL> Locations { get; set; }

    }
    public class RspMenu : Rsp
    {
        public IEnumerable<CategoryBLL> categories { get; set; }
    }

    public class RspOrdersCustomer : Rsp
    {
        public IEnumerable<OrdersBLL> Orders { get; set; }
    }

    public class RspOrdersAdmin : Rsp
    {
        public IEnumerable<OrdersBLL> Orders { get; set; }
    }
    public class RspCustomerLogin : Rsp
    {
        public CustomerBLL customer { get; set; }
    }

    public class RspOrderPunch : Rsp
    {
        public int? OrderNo { get; set; }
        public int OrderID { get; set; }
    }
    public class RspCustomerSignup : Rsp
    {
        public int CustomerID { get; set; }
    }
    public class RspCustomerAddress : Rsp
    {
        public int AddressID { get; set; }
    }
    public class RspCustomerPayment : Rsp
    {
        public int PaymentID { get; set; }
    }

    public class DeliveryAreaBLL
    {
        public int? BrandID { get; set; }
        public int? DeliveryAreaID { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
    }
    public class AboutBLL
    {

        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string BranchTiming { get; set; }
        public int? Discount { get; set; }
        public string DeliveryNo { get; set; }
        public string DiscountDecription { get; set; }
        public string WhatsappNo { get; set; }

    }
    public class AppInfoBLL
    {
        public string AppDescription { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
    public class BrandsBLL
    {
        public int BrandID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CompanyURl { get; set; }
        public string Address { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Currency { get; set; }
        public double? Tax { get; set; }
        public double? DeliveryCharges { get; set; }
        public Nullable<long> BusinessKey { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public double? DiscountApplied { get; set; }
        public List<LocationsBLL> Locations { get; set; }
        public List<DeliveryAreaBLL> DeliveryAreas { get; set; }
        //public List<AboutBLL> AppSettings { get; set; }
        //public List<AppInfoBLL> ApplicationInfo { get; set; }
    }

    public class LocationsBLL
    {
        public Nullable<double> Discounts { get; set; }
        public Nullable<double> Tax { get; set; }
        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public int? LicenseID { get; set; }
        public Nullable<bool> DeliveryServices { get; set; }
        public Nullable<double> DeliveryCharges { get; set; }
        public string DeliveryTime { get; set; }
        public Nullable<double> MinOrderAmount { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string ImageURL { get; set; }
        public Nullable<int> BrandID { get; set; }
        public int MyProperty { get; set; }
        public List<ServiceBLL> ServiceList { get; set; }
    }
    public class Locations
    {

        public int LocationID { get; set; }
        public string BrandName { get; set; }
        public string BrandImage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string Rating { get; set; }
        public string Website { get; set; }
        public bool? IsFeatured { get; set; }
        public List<ServiceBLL> Services { get; set; }
        public List<LocationImage> LocationImages { get; set; }
        public List<AmenitiesBLL> Amenities { get; set; }
        public List<ReviewsBLL> Reviews { get; set; }
        public List<DiscountBLL> Discounts { get; set; }
    }
    public class Services
    {
        public int ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string Image { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string Type { get; set; }
    }
    public class LocationImage
    {
        public int ImageID { get; set; }
        public string ImageURL { get; set; }
        public int? LocationID { get; set; }
    }
    public class CategoryBLL
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int DisplayOrder { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> BrandID { get; set; }

        public List<ItemBLL> items { get; set; }
    }
    public class ItemBLL
    {
        public int ItemID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Barcode { get; set; }
        public string SKU { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Cost { get; set; }
        public string ItemType { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<double> Calories { get; set; }
        public Nullable<bool> IsApplyDiscount { get; set; }
        public Nullable<bool> IsSoldOut { get; set; }
        public List<ModifierBLL> modifiers { get; set; }
        public List<AddonsBLL> addons { get; set; }
    }
    public class ModifierBLL
    {
        public int ItemID { get; set; }
        public int ModifierID { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<double> Price { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> BrandID { get; set; }
    }
    public class AddonsBLL
    {
        public int ItemID { get; set; }
        public int AddonID { get; set; }
        public string Name { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public int StatusID { get; set; }
        public Nullable<int> BrandID { get; set; }

    }
    public class CustomerBLL
    {
        public float DiscountApplied { get; set; }
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> BrandID { get; set; }

        public CustomerDetailBLL details { get; set; }

        public List<CustomerAddressBLL> address { get; set; }
        public List<CustomerPaymentBLL> payment { get; set; }
    }

    public class CustomerDetailBLL
    {
        public int CustomerDetailID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ZipCode { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
    }
    public class CustomerAddressBLL
    {

        public string placeID { get; set; }
        public int addressID { get; set; }
        public string houseNumber { get; set; }
        public string landmark { get; set; }

        public string locationAddress { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string placeType { get; set; }
        public int customerID { get; set; }
        public Nullable<int> brandID { get; set; }
        public Nullable<int> statusID { get; set; }
    }
    public class CustomerPaymentBLL
    {
        public int PaymentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CardExpire { get; set; }
        public string CVV { get; set; }
        public string CardTitle { get; set; }
        public Nullable<int> StatusID { get; set; }
        public int CustomerID { get; set; }
        public Nullable<int> BrandID { get; set; }
    }

    public class TokenBLL
    {
        public int Device { get; set; }
        public int TokenID { get; set; }
        public int? CustomerID { get; set; }
        public string Token { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> StatusID { get; set; }

    }
    public class TransferOrderBLL
    {
        public int FromLocationID { get; set; }
        public int ToLocationID { get; set; }
        public int OrderID { get; set; }

    }
    public class OrdersBLL
    {
        public int OrderID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> TransactionNo { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public string OrderType { get; set; }
        public string OrderDate { get; set; }
        public string OrderDeliveryDate { get; set; }
        public Nullable<System.DateTime> OrderPreparedDate { get; set; }
        public Nullable<System.DateTime> OrderOFDDate { get; set; }
        public Nullable<System.DateTime> OrderDoneDate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string SessionID { get; set; }
        public Nullable<int> OrderTakerID { get; set; }
        public Nullable<int> DeliverUserID { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandLogo { get; set; }
        public string Remarks { get; set; }
        public OrderCheckoutBLL OrderCheckouts { get; set; }
        public OrderCustomerBLL CustomerOrders { get; set; }
        public List<OrderDetailBLL> OrderDetails { get; set; }
        public OrderStatusBLL OrderStatus { get; set; }
    }
    public class OrderStatusBLL
    {
        public OrderStatusChildBLL OrderConfirmed { get; set; }
        public OrderStatusChildBLL FoodPrepared { get; set; }
        public OrderStatusChildBLL DeliveryinProgress { get; set; }
    }
    public class OrderStatusChildBLL
    {
        public string Value { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
    }
    public class OrderDetailBLL
    {
        public int OrderDetailID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string ItemName { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Cost { get; set; }
        public string OrderMode { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }

        public List<OrderModifiersBLL> OrderDetailModifiers { get; set; }

        public List<OrderAddonsBLL> OrderDetailAddons { get; set; }
    }
    public class OrderModifiersBLL
    {
        public int OrderDetailModifierID { get; set; }
        public Nullable<int> OrderDetailID { get; set; }
        public Nullable<int> ModifierID { get; set; }
        public string ModifierName { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Cost { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
    }
    public class OrderAddonsBLL
    {
        public int OrderDetailAddonID { get; set; }
        public Nullable<int> OrderDetailID { get; set; }
        public Nullable<int> AddonID { get; set; }
        public string AddonName { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Cost { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdateDT { get; set; }
    }
    public class OrderCheckoutBLL
    {
        public int OrderCheckoutID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> PaymentMode { get; set; }
        public Nullable<double> AmountPaid { get; set; }
        public Nullable<double> AmountTotal { get; set; }
        public Nullable<double> ServiceCharges { get; set; }
        public Nullable<double> GrandTotal { get; set; }
        public Nullable<double> Tax { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public string CheckoutDate { get; set; }
        public string SessionID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdateBy { get; set; }

        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
    }
    public class OrderCustomerBLL
    {
        public int CustomerOrderID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LocationURL { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string AddressNickName { get; set; }
        public string AddressType { get; set; }
        public string DeliveryArea { get; set; }
    }
    public class PushNoticationBLL
    {
        public string DeviceID { get; set; }
        public string Type { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }
    }

    public class SettingBLL
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string PageName { get; set; }
        public string Type { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
    }
    public class Customers
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Mobile { get; set; }
        public string ImagePath { get; set; }
        public int UserID { get; set; }
        public int LocationID { get; set; }
        public bool? IsEmail { get; set; }
        public bool? IsSMS { get; set; }
        public float? Points { get; set; }
    }
    public class LoginResponse
    {
        public Customers Customer { get; set; }
        public List<Cars> CarList { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
    public class SettingRsp
    {

        public List<Locations> Location { get; set; }
        public List<ServiceBLL> Services { get; set; }
        public List<SettingBLL> Settings { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
    public class UsersListResponse
    {

        public List<UsersList> users = new List<UsersList>();

        public int Status { get; set; }
        public string Description { get; set; }
    }
    public class UsersList
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<int> TimeZoneID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string CompanyCode { get; set; }
    }
    public class LoginVerificationResponse
    {
        public bool verified { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
    public class Cars
    {
        public string CompanyName { get; set; }
        public string CompanyImage { get; set; }
        public int CarID { get; set; }
        public int RowID { get; set; }
        public int CustomerID { get; set; }       
        public Nullable<int> MakeID { get; set; }
        public string MakerImage { get; set; }
        public string MakerName { get; set; }
        public Nullable<int> ModelID { get; set; }
        public string ModelName { get; set; }         
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Year { get; set; }
      
        public string RegistrationNo { get; set; }
        public string ImagePath { get; set; }
        public string MakeImage { get; set; }
        public Nullable<int> LocationID { get; set; }
      
        public string SessionID { get; set; }
        public string RegistrationNoP1 { get; set; }
        public string RegistrationNoP2 { get; set; }
        public string RegistrationNoP3 { get; set; }
        public string RegistrationNoP4 { get; set; }
        public int UserID { get; set; }
        public int? StatusID { get; set; }

        public List<OrdersList> Orders = new List<OrdersList>();
    }

    public class OrdersList
    {
        public string CompanyName { get; set; }
        public string CompanyImage { get; set; }
        public int? OrderCheckoutID { get; set; }
        public int OrderID { get; set; }
        public int? TransactionNo { get; set; }
        public int? OrderNo { get; set; }
        public int CarID { get; set; }
        public string BayName { get; set; }
        public int CustomerID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string OrderPunchDate { get; set; }
        public string CheckoutDate { get; set; }
        public string MechanicName { get; set; }
        public int? Status { get; set; }
        public int? PaymentMode { get; set; }
        public double? AmountTotal { get; set; }
        public double? Tax { get; set; }
        public double? AmountDiscount { get; set; }
        public double? RefundedAmount { get; set; }
        public double? GrandTotal { get; set; }
        public bool? IsPartialPaid { get; set; }
        public string DiscountCode { get; set; }
        public List<OItemsList> Items = new List<OItemsList>();
    }
    public class OItemsList
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> PackageID { get; set; }
        public string ItemName { get; set; }
        public string AlternateName { get; set; }
        public string ItemImage { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> RefundQty { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public Nullable<double> RefundAmount { get; set; }
        public Nullable<double> Cost { get; set; }
        public Nullable<int> StatusID { get; set; }
    }
    public class RspCarMake :Rsp
    { public List<CarMakeList> CarMake = new List<CarMakeList>(); }
        public class CarMakeList
    {
        public List<CarModelList> CarModels = new List<CarModelList>();
        public int MakeID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

    }
    public class CarModelList
    {
        public int? ModelID { get; set; }
        public int? MakeID { get; set; }
        public string Name { get; set; }
        public short? Year { get; set; }
        public string EngineNo { get; set; }
        public string RecommendedLitres { get; set; }
    }
}
