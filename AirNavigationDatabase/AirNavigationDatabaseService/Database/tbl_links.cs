//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirNavigationDatabaseService.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_links
    {
        public long PK_UID { get; set; }
        public Nullable<long> id { get; set; }
        public string country { get; set; }
        public string countrycode { get; set; }
        public string openaiplink { get; set; }
        public string xsourlink { get; set; }
        public Nullable<bool> enabled { get; set; }
        public string weblink { get; set; }
        public Nullable<bool> openaip_enabled { get; set; }
        public Nullable<long> openaip_id_ { get; set; }
    }
}