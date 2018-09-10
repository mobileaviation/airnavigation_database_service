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
            .ForMember(a=>a.geometry, m=>m.MapFrom(u=>u.geometry.AsText())));

            airspace_mapper = new Mapper(airspace_mapper_cfg);

            db = new Database.airnavdbEntities();
        }

        private IMapper airspace_mapper;
        private Database.airnavdbEntities db;

        public List<Airspace> GetCountriesByLimit(int start, int count)
        {
            var countries = (from l in db.tbl_Airspaces
                             select l).OrderBy(a => a.airspace_id).Skip(start).Take(count).ToList();

            return airspace_mapper.Map<List<Database.Airspace>, List<Airspace>>(countries);
        }
    }
}