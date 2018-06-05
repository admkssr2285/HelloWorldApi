using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWorldApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{type}",
                defaults: new { controller = "Home", action = "Index", type = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "DefaultGreetings",
                url: "{controller}/{action}/{type}",
                 defaults: new { controller = "Greetings", action = "Index", type = UrlParameter.Optional }
            );
        }
    }
}
