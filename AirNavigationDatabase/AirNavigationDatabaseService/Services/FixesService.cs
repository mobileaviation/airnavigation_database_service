using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class FixesService
    {
        public FixesService()
        {
            var fix_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Fix, Fix>());

            fix_mapper = new Mapper(fix_mapper_cfg);

            db = new Database.airnavdb_2Entities();
        }

        private IMapper fix_mapper;
        private Database.airnavdb_2Entities db;

        public List<Fix> GetFixesByLimit(int start, int count)
        {
            var fixes = (from l in db.tbl_Fixes
                        select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return fix_mapper.Map<List<Database.Fix>, List<Fix>>(fixes);
        }

        public List<Fix> GetFixesByLimitAndContinent(int start, int count, String continent)
        {
            var fixes = (from l in db.tbl_Fixes
                         where l.continent.Equals(continent)
                         select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return fix_mapper.Map<List<Database.Fix>, List<Fix>>(fixes);
        }
    }
}