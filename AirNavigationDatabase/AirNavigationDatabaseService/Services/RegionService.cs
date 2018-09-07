using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class RegionService
    {
        public RegionService()
        {
            var region_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Region, Region>());

            region_mapper = new Mapper(region_mapper_cfg);

            db = new Database.airnavdbEntities();
        }

        private IMapper region_mapper;
        private Database.airnavdbEntities db;

        public List<Region> GetRegionsByLimit(int start, int count)
        {
            var regions = (from l in db.tbl_Regions
                         select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return region_mapper.Map<List<Database.Region>, List<Region>>(regions);
        }
    }
}