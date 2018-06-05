using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HelloWorldApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "HelloWorldApi",
                routeTemplate: "api/{controller}/{type}",
                defaults: new { type = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "Greetings",
                routeTemplate: "api/{controller}/{type}",
                defaults: new { type = RouteParameter.Optional }
            );
        }
    }
}
