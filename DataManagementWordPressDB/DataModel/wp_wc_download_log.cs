//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManagementWordPressDB.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class wp_wc_download_log
    {
        public decimal download_log_id { get; set; }
        public System.DateTime timestamp { get; set; }
        public decimal permission_id { get; set; }
        public Nullable<decimal> user_id { get; set; }
        public string user_ip_address { get; set; }
    
        public virtual wp_woocommerce_downloadable_product_permissions wp_woocommerce_downloadable_product_permissions { get; set; }
    }
}
