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
    
    public partial class Role_Forms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role_Forms()
        {
            this.Role_GroupForms = new HashSet<Role_GroupForms>();
        }
    
        public int FormID { get; set; }
        public string FormName { get; set; }
        public string RoutePath { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string FormType { get; set; }
        public Nullable<int> SubFormID { get; set; }
        public string CssClass { get; set; }
        public string Icon { get; set; }
        public Nullable<bool> IsMenuItem { get; set; }
        public Nullable<bool> FrontEnd { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<int> StatusID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role_GroupForms> Role_GroupForms { get; set; }
    }
}
