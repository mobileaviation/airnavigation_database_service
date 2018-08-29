using AirNavigationDatabaseService.Database;
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
    public class TestController : ApiController
    {
        [Route("test")]
        [HttpGet]
        public HttpResponseMessage GetLelystad()
        {
            AirportService airportService = new AirportService();
            Airport lelystad = airportService.GetLelystad();
            return Request.CreateResponse(HttpStatusCode.OK, lelystad);
        }
    }
}
