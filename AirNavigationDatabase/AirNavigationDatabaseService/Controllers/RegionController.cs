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
    public class RegionController : ApiController
    {
        [Route("Regions/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetRegionsByLimits(int start, int count)
        {
            RegionService regionsService = new RegionService();
            List<Region> regions = regionsService.GetRegionsByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, regions);
        }
    }
}
