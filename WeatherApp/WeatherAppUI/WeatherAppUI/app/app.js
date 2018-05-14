(function () {
    var app = angular.module('WeatherApp', ['ngRoute']);
    app.config(function ($routeProvider) {
        $routeProvider
        //.when("/weather", {
        //    templateUrl: "app/modules/weather/weather.html",
        //    controller: 'weatherController'
        //})
        .when("/", {
            templateUrl: "app/modules/countries/countries.html",
            controller: 'countriesController'
        })
        .otherwise({ redirectTo: "/" })
    });
}());