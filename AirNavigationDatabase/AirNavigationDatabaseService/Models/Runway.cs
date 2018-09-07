using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Models
{
    public class Runway
    {
        public Int32 id;
        public Int32 airport_ref;
        public String airport_ident;
        public Int32 length_ft;
        public Int32 width_ft;
        public Int32 lighted;
        public Int32 closed;
        public String surface;
        public String le_ident;
        public Double le_latitude_deg;
        public Double le_longitude_deg;
        public Int32 le_elevation_ft;
        public Double le_heading_degT;
        public Int32 le_displaced_threshold_ft;
        public String he_ident;
        public Double he_latitude_deg;
        public Double he_longitude_deg;
        public Int32 he_elevation_ft;
        public Double he_heading_degT;
        public Int32 he_displaced_threshold_ft;
    }
}