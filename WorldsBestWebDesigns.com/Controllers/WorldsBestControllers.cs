using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldsBestWebDesigns.com.Models;

namespace WorldsBestWebDesigns.com.Controllers
{
    public class CommonController : Controller
    {
        public ActionResult footer() => PartialView();
        public ActionResult navbar() => PartialView();
        public ActionResult scripts() => PartialView();
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best MVC Web Designs and Software by Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best Web Designs using MVC .NET in Tampa Bay by Neal Thomas";

            worldsBestResponse.ogData.Description = "Worlds Best Web and Software Designs";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Web Designs by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com";

            return View(worldsBestResponse);
        }

        public ActionResult flexiSlider()       => PartialView();
        public ActionResult tagLine()           => PartialView();
        public ActionResult intro()             => PartialView();
        public ActionResult sliderAd()          => PartialView();
        public ActionResult recentProjects()    => PartialView();
        public ActionResult principalServices() => PartialView();
        public ActionResult ourClients()        => PartialView();
    }

    public class WebDesignController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();
            
            worldsBestResponse.seoData.Description = "Worlds Best MVC Web Designs and Software by Neal C Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best MVC Web Designs in Tampa Bay by Neal Thomas .NET";

            worldsBestResponse.ogData.Description = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "World's Best Web Designs by Neal Thomas";
            worldsBestResponse.ogData.Type = "website";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/web-design/";
            
            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult responsiveWebDesigns() => PartialView();
    }

    public class SoftwareDesignController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best MVC Software Design Patterns by Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Software Designs,Neal Thomas,MVC Software Patterns,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best MVC Software Designs in Tampa Bay by Neal Thomas .NET";

            worldsBestResponse.ogData.Description = "Worlds Best Software Designs by Neal Thomas";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Software Designs by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/software-design/";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult softwareDesign() => PartialView();
    }

    public class WebAppsController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best examples of MVC Web Application and Software Designs by Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best MVC Web Designs in Tampa Bay by Neal Thomas .NET";

            worldsBestResponse.ogData.Description = "Worlds Best Web Applications by Neal Thomas";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Web Application Design by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/web-apps/";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult webApps() => PartialView();
    }

    public class MobileAppsController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best MVC Mobile App Software by Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Mobile App Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best Mobile App Web Designs using MVC .NET in by Neal Thomas";

            worldsBestResponse.ogData.Description = "Worlds Best Mobile App Designs";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Web Designs by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/mobile-apps/";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult mobileApps() => PartialView();
    }

    public class SEOController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best Web Search Engine Optimization Designs by Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best SEO Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best Search Engine Optimizations Designs using MVC .NET in Tampa Bay by Neal Thomas";

            worldsBestResponse.ogData.Description = "Worlds Best Search Engine Optimization Designs";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Search Engine Optimizations by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/search-engine-optimization/";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult SEO() => PartialView();
    }

    public class BrandingController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best Company Branding by Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Branding Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best Company Branding Designs using MVC .NET in Tampa Bay by Neal Thomas";

            worldsBestResponse.ogData.Description = "Worlds Best Branding Software Designs";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Web Designs by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/branding/";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult branding() => PartialView();
    }

    public class AboutUsController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "All About the Worlds Best MVC Software Designer - Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "Neal Thomas is the Worlds Best Web Designer using MVC .NET in Tampa Bay and the World";

            worldsBestResponse.ogData.Description = "Neal Thomas voted the Worlds Best Web and Software Designer in the World";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Web Designs by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/about-us/";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult aboutUs() => PartialView();
        public ActionResult moreAboutUs() => PartialView();
    }

    public class ContactUsController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Contact the Worlds Best MVC Web Designer Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "Contact Neal Thomas The Worlds Best Web Designer using MVC .NET in Tampa Bay by Neal Thomas";

            worldsBestResponse.ogData.Description = "Worlds Best Web and Software Designs";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Contact the Worlds Best Web Designer Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com/contact-me/";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult contactUs() => PartialView();
    }

    public class SiteTechnologyController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best MVC .NET Site Technology in Tampa Bay using Azure";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "Worlds Best MVC .NET Site Technology in Tampa Bays";

            worldsBestResponse.ogData.Description = "Worlds Best Web and Software Designs";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Web Designs by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult aboutThis() => PartialView();
    }

    public class PortfolioController : Controller
    {
        public ActionResult Index()
        {
            WorldsBestResponse worldsBestResponse = new WorldsBestResponse();

            worldsBestResponse.seoData.Description = "Worlds Best MVC Web Designs and Software by Neal Thomas";
            worldsBestResponse.seoData.Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer";
            worldsBestResponse.seoData.Title = "The Worlds Best Web Designs using MVC .NET in Tampa Bay by Neal Thomas";

            worldsBestResponse.ogData.Description = "Worlds Best Web and Software Designs";
            worldsBestResponse.ogData.SiteName = "Worlds Best Web Designs";
            worldsBestResponse.ogData.Title = "Worlds Best Web Designs by Neal Thomas";
            worldsBestResponse.ogData.Title = "If you can dream it, I can build it.";
            worldsBestResponse.ogData.Url = "http://www.worldsbestwebdesigns.com";

            return View(worldsBestResponse);
        }

        public ActionResult breadcrumb() => PartialView();
        public ActionResult portfolio() => PartialView();
        public ActionResult callToAction() => PartialView();
    }
}