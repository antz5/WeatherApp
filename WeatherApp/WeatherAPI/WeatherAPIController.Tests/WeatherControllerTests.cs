using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WeatherAPI.BusinessLogic;
using WeatherAPI.Controllers;
using WeatherAPI.DTO;
using WeatherAPI.Models;

namespace WeatherAPI.Tests.Controllers
{
    [TestClass]
    public class WeatherControllerTests
    {
        [TestMethod]
        public void WeatherDetailsNull()
        {
            //Arrange
            string data = "{\r\n\"coord\": {\r\n \"lon\": 151.22,\r\n\"lat\": -33.85\r\n },\r\n \"weather\": [\r\n {\r\n      \"id\": 521,\r\n\"main\":\"Rain\",\r\n\"description\":\"shower rain\",\r\n\"icon\":\"09n\"\r\n}\r\n],\r\n\"base\": \"stations\",\r\n\"main\": {\r\n\"temp\": 289.29,\r\n\"pressure\": 1022,\r\n\"humidity\": 87,\r\n\"temp_min\":288.15,\r\n\"temp_max\": 290.15\r\n},\r\n\"visibility\": 8000,\r\n\"wind\": {\r\n\"speed\": 15.4,\r\n\"deg\": 190,\r\n\"gust\": 20.6\r\n},\r\n\"clouds\": {\r\n\"all\": 75\r\n},\r\n\"dt\":1526202420,\r\n\"sys\": {\r\n\"type\": 1,\r\n\"id\": 8233,\r\n\"message\": 0.0092,\r\n\"country\": \"AU\",\r\n\"sunrise\": 1526157519,\r\n\"sunset\": 1526195037\r\n},\r\n\"id\": 2147714,\r\n\"name\":\"Sydney\",\r\n\"cod\": 200\r\n}";


            var mockWeatherService = new Mock<IWeatherService>();


            string city = "Sydney";
            string country = "AU";
            RequestDTO request = new RequestDTO() { country = country, city = city };
            var weatherDTO = new WeatherDTO() { cod = "200", clouds = new Clouds() { all = "50" }, coord = new CoOrdinates() { lat = "30", lon = "46" }, dt = "3242342", id = "1277333", main = new Conditions() { humidity = "56", pressure = "565", temp = "34", temp_max = "46", temp_min = "29" }, name = "Sydney", wind = new Wind() { deg = "46", speed = "45" }, visibility = "324", sys = new Event() { country = "Australia", id = "3342", message = "dasfdsf" } };



            mockWeatherService.Setup(x => x.GetWeatherDetails(request)).Returns(data);

            var controller = new WeatherController(mockWeatherService.Object);

            //Act
            var result = controller.WeatherDetails(city, country);

            //Assert
            Assert.AreEqual(null, null);
        }

    
    }
}
