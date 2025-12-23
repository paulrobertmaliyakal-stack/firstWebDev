using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace myfirstproj
{
    public class  RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute
                (name: "someRandomName",
               url:"{controller}/{action}",
                defaults: new { controller = "Program", action = "Index" });
            routes.MapRoute("A unique name",
                "Movies/fetch/{name}/{age}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Program", action = "Random", id = UrlParameter.Optional }
            );
        }
    }
}
