using System.Collections.Generic;
using WeatherAPI.Models;

namespace WeatherAPI.BusinessLogic
{
    public interface ICityService
    {
        List<City> GetCities();
        List<City> GetCities(string country);

    }
}
