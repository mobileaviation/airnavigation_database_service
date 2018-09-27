using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class CountryService
    {
        public CountryService()
        {
            var country_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Country, Country>());

            country_mapper = new Mapper(country_mapper_cfg);

            db = new Database.airnavdb_2Entities();
        }

        private IMapper country_mapper;
        private Database.airnavdb_2Entities db;

        public List<Country> GetCountriesByLimit(int start, int count)
        {
            var countries = (from l in db.tbl_Countries
                           select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return country_mapper.Map<List<Database.Country>, List<Country>>(countries);
        }
    }
}