using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WeatherAPI.BusinessLogic;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class CountriesController : ApiController
    {
        private readonly ICountryService _countryService;
        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public List<Country> Countries()
        {
            try
            {
                var response = _countryService.GetCountries();
                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
