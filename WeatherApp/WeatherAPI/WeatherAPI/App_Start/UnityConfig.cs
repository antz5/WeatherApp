using RestSharp;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.WebApi;
using WeatherAPI.Agents;
using WeatherAPI.Agents.Helper;
using WeatherAPI.BusinessLogic;

namespace WeatherAPI
{
    public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();
		   
			container.RegisterType<IRestClient, RestClient>(new InjectionConstructor("http://api.openweathermap.org/data/2.5/"));
			container.RegisterType<IAgentHelper, AgentHelper>();
			container.RegisterType<IWeatherAgent, WeatherAgent>(new InjectionConstructor(new ResolvedParameter<IRestClient>(), new ResolvedParameter<IAgentHelper>()));
			container.RegisterType<IWeatherService, WeatherService>(new InjectionConstructor(new ResolvedParameter<IWeatherAgent>()));

            container.RegisterType<ICountryService, CountryService>();
            container.RegisterType<ICityService, CityService>();
			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
		}
	}
}