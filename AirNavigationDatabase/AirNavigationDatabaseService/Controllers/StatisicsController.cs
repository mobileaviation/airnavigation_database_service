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
    public class StatisicsController : ApiController
    {
        [Route("Statistics")]
        [HttpGet]
        public HttpResponseMessage GetCounts()
        {
            StatistcsService statistcsService = new StatistcsService();
            Statistics statistics = statistcsService.GetStatistics();


            return Request.CreateResponse(HttpStatusCode.OK, statistics);
        }
    }
}
