using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Models
{
    public class Airspace
    {
        public long id;
        public string name;
        public string version;
        public string category;
        public long airspace_id;
        public string country;
        public long altLimit_top;
        public string altLimit_top_unit;
        public string altLimit_top_ref;
        public long altLimit_bottom;
        public string altLimit_bottom_unit;
        public string altLimit_bottom_ref;
        public string geometry;
    }
}