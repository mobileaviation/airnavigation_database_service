using AirNavigationDatabaseService.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirNavigationDatabaseService.Services
{
    public class TileService
    {
        public TileService()
        {
            var tile_mapper_cfg = new MapperConfiguration(cfg => cfg.CreateMap<Database.Tile, Tile>());

            tile_mapper = new Mapper(tile_mapper_cfg);

            db = new Database.airnavdbEntities();
        }

        private IMapper tile_mapper;
        private Database.airnavdbEntities db;

        public List<Tile> GetTilesByLimit(int start, int count)
        {
            var tiles = (from l in db.tbl_Tiles
                            select l).OrderBy(a => a.C_id).Skip(start).Take(count).ToList();

            return tile_mapper.Map<List<Database.Tile>, List<Tile>>(tiles);
        }
    }
}