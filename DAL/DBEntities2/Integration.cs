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
    
    public partial class Integration
    {
        public int IntegrationID { get; set; }
        public string Name { get; set; }
        public string IntegrationKey { get; set; }
        public string Token { get; set; }
        public string Value { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual User User { get; set; }
    }
}
