using WeatherAPI.DTO;

namespace WeatherAPI.BusinessLogic
{
    public interface IWeatherService
    {
        string GetWeatherDetails(RequestDTO request);
    }
}
