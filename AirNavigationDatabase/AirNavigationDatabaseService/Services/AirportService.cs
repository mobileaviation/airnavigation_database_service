
using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class AirportService
    {
        public AirportService()
        {
            var airport_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Airport, Airport>()
                .ForMember(d => d.runways, opt => opt.MapFrom(c => c.tbl_Runways))
                .ForMember(d => d.frequencies, opt =>opt.MapFrom(c => c.tbl_Frequencies)));
                
            airport_mapper = new Mapper(airport_mapper_cfg);
            
            db = new Database.airnavdb_2Entities();
        }

        private IMapper airport_mapper;
        private Database.airnavdb_2Entities db;

        public Airport GetLelystad()
        {
            var lelystad = from l in db.tbl_Airports
                           where l.ident.Equals("EHLE")
                           select l;

            Database.Airport db_airport = lelystad.FirstOrDefault();

            return airport_mapper.Map<Airport>(db_airport);
        }

        public List<Airport> GetAirportsByCountryCode(String country)
        {
            var airports = (from l in db.tbl_Airports
                           where l.iso_country.Equals(country)
                           select l).ToList();

            return airport_mapper.Map<List<Database.Airport>, List<Airport>>(airports);
        }

        public List<Airport> GetAirportsByLimit(int start, int count)
        {
            var airports = (from l in db.tbl_Airports
                            select l).OrderBy(a => a.id).Skip(start).Take(count).ToList();

            return airport_mapper.Map<List<Database.Airport>, List<Airport>>(airports);
        }

    }
}