//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManagementWordPressDB.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class wp_users
    {
        public decimal ID { get; set; }
        public string user_login { get; set; }
        public string user_pass { get; set; }
        public string user_nicename { get; set; }
        public string user_email { get; set; }
        public string user_url { get; set; }
        public System.DateTime user_registered { get; set; }
        public string user_activation_key { get; set; }
        public int user_status { get; set; }
        public string display_name { get; set; }
    }
}