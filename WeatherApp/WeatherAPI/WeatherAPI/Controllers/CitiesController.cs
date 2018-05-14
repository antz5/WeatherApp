﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WeatherAPI.BusinessLogic;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CitiesController : ApiController
    {
        private readonly ICityService _cityService;
        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]        
        public List<City> CityDetails(string country)
        {
            try
            {
                var response = _cityService.GetCities(country);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
    }
}
