using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNET_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "clientEdit",
                url: "me/edit/{id}",
                defaults: new { controller = "ClientAuthenticated", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "clientDelete",
                url: "me/delete/{id}",
                defaults: new { controller = "ClientAuthenticated", action = "Delete", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "clientAdd",
                url: "me/add",
                defaults: new { controller = "ClientAuthenticated", action = "Add" }
            );

            routes.MapRoute(
                name: "clientIndex",
                url: "me/",
                defaults: new { controller = "ClientAuthenticated", action = "ClientIndex" }
            );

            routes.MapRoute(
                name: "logout",
                url: "authentication/logout",
                defaults: new { controller = "ClientAuthenticated", action = "Logout" }
            );

            routes.MapRoute(
                name: "login",
                url: "authentication/login",
                defaults: new { controller = "Authentication", action = "Login" }
            );

            routes.MapRoute(
                name: "signup",
                url: "authentication/signup",
                defaults: new { controller = "Authentication", action = "SignUp" }
            );

            routes.MapRoute(
                name: "aboutus",
                url: "aboutus",
                defaults: new { controller = "Client", action = "About" }
            );

            routes.MapRoute(
                name: "features",
                url: "features",
                defaults: new { controller = "Client", action = "Features" }
            );

            routes.MapRoute(
                name: "pricing",
                url: "pricing",
                defaults: new { controller = "Client", action = "Pricing" }
            );

            routes.MapRoute(
                name: "index",
                url: "",
                defaults: new { controller = "Client", action = "Index" }
            );
        }
    }
}
