//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wepbanquanao_nguyenquangmanh_k22cnt1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_Support
    {
        public int support_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string issue_description { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        public virtual User User { get; set; }
    }
}
