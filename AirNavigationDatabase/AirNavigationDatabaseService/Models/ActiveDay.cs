using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Models
{
    public class ActiveDay
    {
        public string day;
        public System.TimeSpan start;
        public System.TimeSpan end;
        public string timezone;
    }
}