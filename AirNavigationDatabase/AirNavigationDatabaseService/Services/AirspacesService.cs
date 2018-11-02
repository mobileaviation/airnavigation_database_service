using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class AirspacesService
    {
        public AirspacesService()
        {
            var airspace_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Airspace, Airspace>()
            .ForMember(d => d.atcStations, opt => opt.MapFrom(c => c.tbl_ATCStations))
            .ForMember(d => d.activeDays, opt => opt.MapFrom(c => c.tbl_ActiveDays))
            .ForMember(d => d.activePeriods, opt => opt.MapFrom(c => c.tbl_ActivePeriods))
            .ForMember(a=>a.geometry, m=>m.MapFrom(u=>u.geometry.AsText())));

            airspace_mapper = new Mapper(airspace_mapper_cfg);

            db = new Database.airnavdb_2Entities();
        }

        private IMapper airspace_mapper;
        private Database.airnavdb_2Entities db;

        public List<Airspace> GetAirspacesByLimit(int start, int count)
        {
            var airspaces = (from l in db.tbl_Airspaces
                             select l).OrderBy(a => a.airspace_id).Skip(start).Take(count).ToList();

            

            return airspace_mapper.Map<List<Database.Airspace>, List<Airspace>>(airspaces);
        }

        public List<Airspace> GetAirspacesByCountry(String country)
        {
            var airspaces = (from l in db.tbl_Airspaces
                             where l.country==country
                             select l).ToList();

            return airspace_mapper.Map<List<Database.Airspace>, List<Airspace>>(airspaces);
        }
    }
}