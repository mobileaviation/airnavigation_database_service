using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class NavaidsService
    {
        public NavaidsService()
        {
            var navaid_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Navaid, Navaid>());

            navaid_mapper = new Mapper(navaid_mapper_cfg);

            db = new Database.airnavdb_2Entities();
        }

        private IMapper navaid_mapper;
        private Database.airnavdb_2Entities db;

        public List<Navaid> GetNavaidsByLimit(int start, int count)
        {
            var navaids = (from l in db.tbl_Navaids
                         select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return navaid_mapper.Map<List<Database.Navaid>, List<Navaid>>(navaids);
        }

        public List<Navaid> GetNavaidsByLimitAndContinents(int start, int count, String continent)
        {
            var navaids = (from l in db.tbl_Navaids
                           where l.continent.Equals(continent)
                           select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return navaid_mapper.Map<List<Database.Navaid>, List<Navaid>>(navaids);
        }
    }
}