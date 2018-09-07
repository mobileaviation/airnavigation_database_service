using AirNavigationDatabaseService.Models;
using AirNavigationDatabaseService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirNavigationDatabaseService.Controllers
{
    [RoutePrefix("v1/airnavdb")]
    public class TileController : ApiController
    {
        [Route("Tiles/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetTilesByLimits(int start, int count)
        {
            TileService tilesService = new TileService();
            List<Tile> tiles = tilesService.GetTilesByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, tiles);
        }
    }
}
