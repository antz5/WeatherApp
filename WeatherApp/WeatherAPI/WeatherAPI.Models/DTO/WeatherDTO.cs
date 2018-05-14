using WeatherAPI.Models;

namespace WeatherAPI.DTO
{
    public class WeatherDTO
    {
        public CoOrdinates coord { get; set; }
        public Weather[] weather { get; set; }
        public Conditions main { get; set; }
        public string visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public string dt { get; set; }
        public Event sys { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cod { get; set; }
    }
}