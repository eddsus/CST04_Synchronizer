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
    
    public partial class wp_wcpdf_invoice_number
    {
        public int id { get; set; }
        public Nullable<int> order_id { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> calculated_number { get; set; }
    }
}
