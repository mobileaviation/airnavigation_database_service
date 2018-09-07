using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Models
{
    public class Tile
    {
        public Int32 index;
        public String name;
        public String region;
        public String type;
        public String mbtileslink;
        public String xmllink;
        public String version;
        public long startValidity;
        public long endValidity;
    }
}