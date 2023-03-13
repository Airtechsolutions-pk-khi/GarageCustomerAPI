//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DBEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Cars = new HashSet<Car>();
        }
    
        public int CustomerID { get; set; }
        public int RowID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Barcode { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Sex { get; set; }
        public string Mobile { get; set; }
        public string CardNo { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<double> Points { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<double> Redem { get; set; }
        public Nullable<System.DateTime> LastVisit { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<bool> IsEmail { get; set; }
        public Nullable<bool> IsSMS { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<bool> IsSignUp { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
