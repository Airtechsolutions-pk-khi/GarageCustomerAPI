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
    
    public partial class CarSell
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarSell()
        {
            this.CarFavourites = new HashSet<CarFavourite>();
            this.CarSellImages = new HashSet<CarSellImage>();
        }
    
        public int CarSellID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RegistrationNo { get; set; }
        public string BodyType { get; set; }
        public Nullable<int> BodyTypeID { get; set; }
        public string FuelType { get; set; }
        public string EngineType { get; set; }
        public string Year { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> MakeID { get; set; }
        public Nullable<int> ModelID { get; set; }
        public string Transmition { get; set; }
        public string Kilometer { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> IsInspected { get; set; }
        public Nullable<int> CityID { get; set; }
        public string CountryCode { get; set; }
        public string Address { get; set; }
        public Nullable<int> CarSellAddID { get; set; }
        public string BodyColor { get; set; }
        public string Assembly { get; set; }
        public string Image { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Reason { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarFavourite> CarFavourites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarSellImage> CarSellImages { get; set; }
    }
}
