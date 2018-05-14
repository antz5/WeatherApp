(function () {

    var weather = function ($http) {
        var getWeatherDetails = function (city, country) {
            return $http.get('http://localhost:50782/api/Weather/WeatherDetails?city=' + city + '&country=' + country)
            .then(function (response) {
                return response.data;
            })
        };
        return {
            getWeatherDetails: getWeatherDetails
        };
    }
    angular.module('WeatherApp').factory("weatherService", ['$http', weather]);
}());