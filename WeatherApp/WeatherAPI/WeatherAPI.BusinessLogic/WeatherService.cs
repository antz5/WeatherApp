using WeatherAPI.Agents;
using WeatherAPI.DTO;

namespace WeatherAPI.BusinessLogic
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherAgent _weatherAgent;

        public WeatherService(IWeatherAgent weatherAgent)
        {
            _weatherAgent = weatherAgent;
        }

        /// <summary>
        /// Gets the weather details
        /// </summary>
        /// <param name="request"></param>
        /// <returns>returns a json response</returns>
        public string GetWeatherDetails(RequestDTO request)
        {
            var result =  _weatherAgent.GetWeatherDetails(request);
            return result;
        }
    }
}
