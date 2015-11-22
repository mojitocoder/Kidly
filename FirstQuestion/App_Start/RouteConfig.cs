using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstQuestion
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Make sure the generated URLs are canonical
            routes.AppendTrailingSlash = true;
            routes.LowercaseUrls = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Brand",
                url: "b/{brandname}",
                defaults: new { controller = "Brand", action = "Index", brandname = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Product",
                url: "p/{brandname}/{productname}/{id}",
                defaults: new { controller = "Product", action = "ProductId", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Brand", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
