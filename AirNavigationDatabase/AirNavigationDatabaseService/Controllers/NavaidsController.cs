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
    public class NavaidsController : ApiController
    {
        [Route("Navaids/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetAirportsByLimits(int start, int count)
        {
            NavaidsService navaidsService = new NavaidsService();
            List<Navaid> navaids = navaidsService.GetNavaidsByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, navaids);
        }
    }
}
