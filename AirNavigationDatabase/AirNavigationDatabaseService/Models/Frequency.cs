using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Models
{
    public class Frequency
    {
        public Int32 id;
        public Int32 airport_ref;
        public String airport_ident;
        public String type;
        public String description;
        public Double frequency_mhz;
    }
}