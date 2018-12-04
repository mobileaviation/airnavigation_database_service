using AirNavigationDatabaseService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class StatistcsService
    {
        public StatistcsService()
        {
            db = new Database.airnavdb_2Entities();
        }

        private Database.airnavdb_2Entities db;

        public Statistics GetStatistics()
        {
            Statistics s = new Statistics();

            s.AirportsCount = (from a in db.tbl_Airports select a).Count();
            s.NavaidsCount = (from a in db.tbl_Navaids select a).Count();
            s.MBTilesCount = (from a in db.tbl_Tiles select a).Count();
            s.PropertiesCount = 0;
            s.RegionsCount = (from a in db.tbl_Regions select a).Count();
            s.FixesCount = (from a in db.tbl_Fixes select a).Count();
            s.FirsCount = (from a in db.tbl_Firs select a).Count();
            s.CountriesCount = (from a in db.tbl_Countries select a).Count();
            s.AirspacesCount = (from a in db.tbl_Airspaces select a).Count();
            s.CitiesCount = (from a in db.tbl_Cities select a).Count();
            s.Version = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

            return s;
        }

        public Statistics GetStatisticsByContinent(String continent)
        {
            Statistics s = new Statistics();

            s.AirportsCount = (from a in db.tbl_Airports where a.continent.Equals(continent) select a).Count();
            s.NavaidsCount = (from a in db.tbl_Navaids where a.continent.Equals(continent) select a).Count();
            s.MBTilesCount = (from a in db.tbl_Tiles select a).Count();
            s.PropertiesCount = 0;
            s.RegionsCount = (from a in db.tbl_Regions select a).Count();
            s.FixesCount = (from a in db.tbl_Fixes where a.continent.Equals(continent) select a).Count();
            s.FirsCount = (from a in db.tbl_Firs select a).Count();
            s.CountriesCount = (from a in db.tbl_Countries select a).Count();
            s.AirspacesCount = (from a in db.tbl_Airspaces where a.continent.Equals(continent) select a).Count();
            s.CitiesCount = (from a in db.tbl_Cities where a.continent.Equals(continent) select a).Count();
            s.Version = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));

            return s;
        }
    }
}