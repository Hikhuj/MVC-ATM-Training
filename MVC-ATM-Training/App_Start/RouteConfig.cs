using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_ATM_Training
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // Nueva ruta agregada por mi.
            // EJEMPLO DE GET REQUEST
            // Parameters will not be part of URL
            /*
            routes.MapRoute(
                name: "Serial number",
                url: "serial/{letterCase}",
                defaults: new { controller = "Home", action = "Serial", letterCase = "upper"}
            );
            */

            routes.MapRoute(
                name: "Serial number",
                url: "serial/{letterCase}",
                defaults: new { controller = "Home", action = "Serial", letterCase = "upper" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
