using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Models
{
    public class Airport
    {
        public Airport()
        {
            runways = new List<Runway>();
            frequencies = new List<Frequency>();
        }

        public Int32 index;
        public Int32 id;
        public String ident;
        public String type;
        public String name;
        public Double latitude_deg;
        public Double longitude_deg;
        public Double elevation_ft;
        public String continent;
        public String iso_country;
        public String iso_region;
        public String municipality;
        public String scheduled_service;
        public String gps_code;
        public String iata_code;
        public String local_code;
        public String home_link;
        public String wikipedia_link;
        public String keywords;

        public List<Runway> runways;
        public List<Frequency> frequencies;
    }
}