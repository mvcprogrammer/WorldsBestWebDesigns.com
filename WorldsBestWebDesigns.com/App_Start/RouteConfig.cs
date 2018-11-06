using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WorldsBestWebDesigns.com
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "SiteTechnology",
                url: "site-technology",
                defaults: new { controller = "SiteTechnology", action = "Index" }
            );

            routes.MapRoute(
                name: "ReachMe",
                url: "contact-me",
                defaults: new { controller = "ContactUs", action = "Index" }
            );

            routes.MapRoute(
                name: "ReachUs",
                url: "contact-us",
                defaults: new { controller = "ContactUs", action = "Index" }
            );

            routes.MapRoute(
                name: "AboutMe",
                url: "about-me",
                defaults: new { controller = "AboutUs", action = "Index" }
            );


            routes.MapRoute(
                name: "AboutUs",
                url: "about-us",
                defaults: new { controller = "AboutUs", action = "Index" }
            );

            routes.MapRoute(
                name: "Branding",
                url: "branding",
                defaults: new { controller = "Branding", action = "Index" }
            );

            routes.MapRoute(
                name: "SEO",
                url: "search-engine-optimization",
                defaults: new { controller = "SEO", action = "Index" }
            );

            routes.MapRoute(
                name: "MobileApps",
                url: "mobile-apps",
                defaults: new { controller = "MobileApps", action = "Index" }
            );

            routes.MapRoute(
                name: "WebApps",
                url: "web-apps",
                defaults: new { controller = "WebApps", action = "Index" }
            );

            routes.MapRoute(
                name: "SoftwareDesign",
                url: "software-design",
                defaults: new { controller = "SoftwareDesign", action = "Index" }
            );

            routes.MapRoute(
                name: "WebDesign",
                url: "web-design",
                defaults: new { controller = "WebDesign", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
