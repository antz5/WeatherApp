using System;

namespace WeatherAPI.Models
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        //public CoOrdinates coord { get; set; }
           
    }
    [Serializable]
    public class CoOrdinates
    {
        public string lon { get; set; }
        public string lat { get; set; }
    }
}