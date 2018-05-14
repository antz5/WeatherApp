using Newtonsoft.Json;
using System.Collections.Generic;
using WeatherAPI.Models;

namespace WeatherAPI.BusinessLogic
{
    public class CountryService : ICountryService
    {
        /// <summary>
        /// Reads the json file which consists of data related to Countries
        /// </summary>
        /// <returns>returns a list of countries</returns>
        public List<Country> GetCountries()
        {
            //Read data from json file
            const string countriesJson = "countries.json";
            string countries = Helper.JsonHelper.ReadDataFromResource(countriesJson);
            var data = JsonConvert.DeserializeObject<List<Country>>(countries);
            return data;
        }
    }
}
