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
    
    public partial class Review
    {
        public int ReviewID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Rate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> LikeCount { get; set; }
        public Nullable<int> DislikeCount { get; set; }
        public string ReportAbuse { get; set; }
        public Nullable<int> CustomerID { get; set; }
    }
}
