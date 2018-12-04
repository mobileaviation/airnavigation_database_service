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
    public class FixController : ApiController
    {
        [Route("Fixes/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetFixesByLimits(int start, int count)
        {
            FixesService fixesService = new FixesService();
            List<Fix> fixes = fixesService.GetFixesByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, fixes);
        }

        [Route("Fixes/limit/{continent}/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetFixesByLimitsAndContinent(int start, int count, String continent)
        {
            FixesService fixesService = new FixesService();
            List<Fix> fixes = fixesService.GetFixesByLimitAndContinent(start, count, continent);
            return Request.CreateResponse(HttpStatusCode.OK, fixes);
        }
    }
}
