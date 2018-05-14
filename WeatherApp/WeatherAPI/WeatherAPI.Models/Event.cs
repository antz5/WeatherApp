namespace WeatherAPI.Models
{
    public class Event
    {
        public string type { get; set; }
        public string id { get; set; }
        public string message { get; set; }
        public string country { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }
}