using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Models
{
    public class City
    {
        public int geonameid;
        public string name;
        public string asciiname;
        public string alternatenames;
        public double latitude;
        public double longitude;
        public string feature_class;
        public string feature_code;
        public string country_code;
        public string cc2;
        public string admin1_code;
        public string admin2_code;
        public string admin3_code;
        public string admin4_code;
        public int population;
        public int elevation;
        public string dem;
        public string timezone;
        public System.DateTime modification_date;
    }
}