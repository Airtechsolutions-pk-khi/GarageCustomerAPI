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
    
    public partial class CarInspectionDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarInspectionDetail()
        {
            this.OrderInspectionMappings = new HashSet<OrderInspectionMapping>();
        }
    
        public int CarInspectionDetailID { get; set; }
        public int CarInspectionID { get; set; }
        public string Name { get; set; }
        public string AlternateName { get; set; }
        public string Description { get; set; }
        public string km5000 { get; set; }
        public string km8000 { get; set; }
        public string km10000 { get; set; }
        public string km15000 { get; set; }
        public string kmother { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
    
        public virtual CarInspection CarInspection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInspectionMapping> OrderInspectionMappings { get; set; }
    }
}