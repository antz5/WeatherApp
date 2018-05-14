using WeatherAPI.DTO;

namespace WeatherAPI.Agents
{
    public interface IWeatherAgent
    {
        string GetWeatherDetails(RequestDTO requestDto);        
    }
}
