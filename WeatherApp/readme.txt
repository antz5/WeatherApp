To Run the application

1. Run the WeatherAPI (web api project)-opens a swagger page
2. if the api fails to load the weather api, check for the API key defined in the WeatherAgent.cs
3.Run the WeatherAppUI(Angular.js) project
4.Modify the url pointing to localhost webapi in the countriesService.js, weatherService.js and citiesService.js
5.Most of the business logic reside in countriesController.js file.

NOTE: 
Since the webservice : http://www.webservicex.net/globalweather.asmx?op=GetCitiesByCountry

was not working, I have mocked the data in two separate json file to load the cities and countries data. However, to retrieve the weather details, I have used the http://api.openweathermap.org/data/2.5/weather url.