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
    public class CitiesController : ApiController
    {
        [Route("cities/{country}")]
        [HttpGet]
        public HttpResponseMessage getCitiesByCountrycode(String country)
        {
            CitiesService citiesService = new CitiesService();
            List<City> cities = citiesService.getCitiesByCountryCode(country);
            return Request.CreateResponse(HttpStatusCode.OK, cities);
        }

        [Route("cities/limit/{start}/{count}")]
        [HttpGet]
        public HttpResponseMessage getCitiesByLimit(int start, int count)
        {
            CitiesService citiesService = new CitiesService();
            List<City> cities = citiesService.getCitiesByLimit(start, count);
            return Request.CreateResponse(HttpStatusCode.OK, cities);
        }
    }
}
