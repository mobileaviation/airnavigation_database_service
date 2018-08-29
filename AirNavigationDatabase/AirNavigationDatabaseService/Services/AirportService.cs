using AirNavigationDatabaseService.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class AirportService
    {
        public Airport GetLelystad()
        {
            airnavdbEntities db = new airnavdbEntities();
            var lelystad = from l in db.tbl_Airports
                           where l.ident.Equals("EHLE")
                           select l;

            return lelystad.FirstOrDefault();
        }
    }
}