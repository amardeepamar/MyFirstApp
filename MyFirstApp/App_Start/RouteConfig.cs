using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // This is Conventional Url Routing start here
            // routes.MapRoute(
            //    name: "Products",
            //    url: "Products/GetProductId/{ProductName}",
            //    defaults: new { controller = "Products", action = "GetProductId" }
            //);

            //routes.MapRoute(
            //                name: "products",
            //                url: "{controller}/{action}/{productName}",
            //                defaults: new { },
            //                constraints: new { productName = @"^[A-Za-z ]*$" }
            //            );


            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "StudentDetails", id = UrlParameter.Optional }
            //);

            // This is Conventional Url Routing End here

            // This is Attribute Routing start here
            routes.MapMvcAttributeRoutes();
            // This is Attribute Routing End here
        }
    }
}
