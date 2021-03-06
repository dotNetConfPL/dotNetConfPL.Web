﻿using System.Web.Mvc;
using System.Web.Routing;

namespace dotnetconfpl
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.RouteExistingFiles = true;
            routes.MapRoute(
                name: "GoogleVerification",
                url: "{page}.html",
                defaults: new { controller = "Home", action = "Html", page = UrlParameter.Optional },
                namespaces: new string[] { "dotnetconfpl.Controllers" }
            );

            routes.MapRoute(
                "HomeRoute",
                "{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "dotnetconfpl.Controllers" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    constraints: new[] { "dotnetconfpl.Controllers" }
            //);
        }
    }
}