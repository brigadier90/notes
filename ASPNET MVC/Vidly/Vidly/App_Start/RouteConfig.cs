using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //THERE IS A BEETER WAY TO ADD ROUTES. NO NEED TO GO BACK AND FORTH IF WE CHANGE CONTROLLER NAME
            //OR SOMETHING
            //1) enable attribute routing
            routes.MapMvcAttributeRoutes();
            
            

            //NOTE routes must be ordered from mostspecific to most generic
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/release/{year}/{month}", //turns out not case sensitive
                new { controller = "Movies", action = "ByReleaseDate"},
                //can add contraints as regex
                new {year = @"\d{4}", month = @"\d{2}" } //can do @"2015|2016" either 15 or 16 only



            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
