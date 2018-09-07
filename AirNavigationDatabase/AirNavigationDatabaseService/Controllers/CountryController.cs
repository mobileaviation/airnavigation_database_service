using System;
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
    public class CountryController : ApiController
    {
        [Route("Countries/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage GetCountriesByLimits(int start, int count)
        {
            CountryService countriesService = new CountryService();
            List<Country> counrtries = countriesService.GetCountriesByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, counrtries);
        }
    }
}
