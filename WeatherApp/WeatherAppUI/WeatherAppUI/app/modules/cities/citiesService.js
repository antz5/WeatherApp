(function () {

    var cities = function ($http) {
        var getCities= function (countryCode) {
            return $http.get('http://localhost:50782/api/Cities/CityDetails?country=' + countryCode)
            .then(function (response) {
                return response.data;
            })
        };
        return {
            getCities: getCities
        };
    }
    angular.module('WeatherApp').factory("citiesService", ['$http', cities]);
}());