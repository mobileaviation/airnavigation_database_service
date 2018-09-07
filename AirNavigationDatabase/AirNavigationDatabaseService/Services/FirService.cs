using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class FirService
    {
        public FirService()
        {
            var fir_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Fir, Fir>());

            fir_mapper = new Mapper(fir_mapper_cfg);

            db = new Database.airnavdbEntities();
        }

        private IMapper fir_mapper;
        private Database.airnavdbEntities db;

        public List<Fir> GetFirsByLimit(int start, int count)
        {
            var firs = (from l in db.tbl_Firs
                             select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return fir_mapper.Map<List<Database.Fir>, List<Fir>>(firs);
        }
    }
}