﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SurveyBase1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}"
            );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{name}/{id}",
                defaults: new { controller = "Survey", action = "Landing", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Landing",
                url: "{controller}/{action}/{name}/{id}"
            );

            routes.MapRoute(
                name: "Workflow",
                url: "{controller}/{action}"
            );
        }
    }
}
