using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Http.Cors;
using WeatherAPI.BusinessLogic;
using WeatherAPI.DTO;

namespace WeatherAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WeatherController : ApiController
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public WeatherDTO WeatherDetails(string city, string country)
        {
            var request = new RequestDTO() { city = city, country = country };
           var response = _weatherService.GetWeatherDetails(request);
            return JsonConvert.DeserializeObject<WeatherDTO>(response);
        }
    }
}
