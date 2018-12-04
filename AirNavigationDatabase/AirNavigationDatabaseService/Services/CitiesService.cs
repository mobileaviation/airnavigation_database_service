using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class CitiesService
    {
        public CitiesService()
        {
            var cities_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.City, City>());
            cities_mapper = new Mapper(cities_mapper_cfg);

            db = new Database.airnavdb_2Entities();
        }

        private IMapper cities_mapper;
        private Database.airnavdb_2Entities db;

        public List<City> getCitiesByCountryCode(String code)
        {
            var cities = from c in db.tbl_Cities
                         where c.country_code == code
                         select c;

            return cities_mapper.Map<List<Database.City>, List<City>>(cities.ToList()); 
        }

        public List<City> getCitiesByLimit(int start, int count)
        {
            var cities = (from l in db.tbl_Cities
                            select l).OrderBy(a => a.geonameid).Skip(start).Take(count).ToList();

            return cities_mapper.Map<List<Database.City>, List<City>>(cities);
        }

        public List<City> getCitiesByLimitAndContinent(int start, int count, String continent)
        {
            var cities = (from l in db.tbl_Cities
                          where l.continent.Equals(continent)
                          select l).OrderBy(a => a.geonameid).Skip(start).Take(count).ToList();

            return cities_mapper.Map<List<Database.City>, List<City>>(cities);
        }
    }
}