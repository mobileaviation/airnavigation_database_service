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
    
    public partial class City
    {
        public int geonameid { get; set; }
        public string name { get; set; }
        public string asciiname { get; set; }
        public string alternatenames { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string feature_class { get; set; }
        public string feature_code { get; set; }
        public string country_code { get; set; }
        public string cc2 { get; set; }
        public string admin1_code { get; set; }
        public string admin2_code { get; set; }
        public string admin3_code { get; set; }
        public string admin4_code { get; set; }
        public int population { get; set; }
        public int elevation { get; set; }
        public string dem { get; set; }
        public string timezone { get; set; }
        public System.DateTime modification_date { get; set; }
    }
}
