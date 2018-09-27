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
    public class AirspacesController : ApiController
    {
        [Route("airspaces/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetAirspacesByLimits(int start, int count)
        {
            AirspacesService airspacesService = new AirspacesService();
            List<Airspace> airspaces = airspacesService.GetAirspacesByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, airspaces);
        }

        [Route("airspaces/country/{country}")]
        [HttpGet]
        public HttpResponseMessage GetAirspacesByCountry(String country)
        {
            AirspacesService airspacesService = new AirspacesService();
            List<Airspace> airspaces = airspacesService.GetAirspacesByCountry(country);
            return Request.CreateResponse(HttpStatusCode.OK, airspaces);
        }
    }
}
