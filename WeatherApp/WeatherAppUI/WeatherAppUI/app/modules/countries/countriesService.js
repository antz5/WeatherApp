(function () {

    var countries = function ($http) {
        var getCountries = function () {
            return $http.get('http://localhost:50782/api/Countries/Countries')
            .then(function (response) {
                return response.data;
            })
        };
        return {
            getCountries: getCountries
        };
    }
    angular.module('WeatherApp').factory("countriesService", ['$http', countries]);
}());