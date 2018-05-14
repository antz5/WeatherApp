using System.Collections.Generic;
using WeatherAPI.Models;

namespace WeatherAPI.BusinessLogic
{
    public interface ICountryService
    {
        List<Country> GetCountries();        
    }
}
