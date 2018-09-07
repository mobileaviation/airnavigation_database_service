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
    public class AirportsController : ApiController
    {
        [Route("airports/{country}")]
        [HttpGet]
        public HttpResponseMessage GetAirportsByCountry(string country)
        {
            AirportService airportService = new AirportService();
            List<Airport> airports = airportService.GetAirportsByCountryCode(country);
            return Request.CreateResponse(HttpStatusCode.OK, airports);
        }

        [Route("airports/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetAirportsByLimits(int start, int count)
        {
            AirportService airportService = new AirportService();
            List<Airport> airports = airportService.GetAirportsByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, airports);
        }
    }
}
