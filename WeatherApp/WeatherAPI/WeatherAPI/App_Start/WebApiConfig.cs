﻿using Swashbuckle.Application;
using System.Web.Http;

namespace WeatherAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Routes.MapHttpRoute(
          name: "Swagger UI",
          routeTemplate: "",
          defaults: null,
          constraints: null,
          handler: new RedirectHandler(SwaggerDocsConfig.DefaultRootUrlResolver, "swagger/ui/index"));
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
