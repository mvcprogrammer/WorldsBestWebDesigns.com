    using System.Web.Mvc;
using WorldsBestWebDesigns.com.Models;

namespace WorldsBestWebDesigns.com.Controllers
{
    public class CommonController : Controller
    {
        public ActionResult Footer() => PartialView();
        public ActionResult Navbar() => PartialView();
        public ActionResult Scripts() => PartialView();
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best MVC Web Designs and Software by Neal Thomas",
                    Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "The Worlds Best Web Designs using MVC .NET in Tampa Bay by Neal Thomas"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Web and Software Designs",
                    SiteName = "Worlds Best Web Designs",
                    Title = "World's Best Web Designs by Neal Thomas",
                    Type = "website",
                    Url = "http://www.worldsbestwebdesigns.com"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult FlexiSlider()       => PartialView();
        public ActionResult TagLine()           => PartialView();
        public ActionResult Intro()             => PartialView();
        public ActionResult SliderAd()          => PartialView();
        public ActionResult RecentProjects()    => PartialView();
        public ActionResult PrincipalServices() => PartialView();
        public ActionResult OurClients()        => PartialView();
    }

    public class WebDesignController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best MVC Web Designs and Software by Neal C Thomas",
                    Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,,Tampa Bay Web Designer",
                    Title = "The Worlds Best MVC Web Designs in Tampa Bay by Neal Thomas .NET"
                },
                OgData = new OgData
                {
                    Description = "If you can dream it, I can build it.",
                    SiteName = "Worlds Best Web Designs",
                    Title = "World's Best Web Designs by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/web-design/"
                }
            };
            
            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult ResponsiveWebDesigns() => PartialView();
    }

    public class SoftwareDesignController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best MVC Software Design Patterns by Neal Thomas",
                    Keywords = "Worlds Best Software Designs,Neal Thomas,MVC Software Patterns,Tampa Bay Web Designer",
                    Title = "The Worlds Best MVC Software Designs in Tampa Bay by Neal Thomas .NET"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Software Designs by Neal Thomas",
                    SiteName = "Worlds Best Web Designs",
                    Title = "Worlds Best Software Designs by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/web-design/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult SoftwareDesign() => PartialView();
    }

    public class WebAppsController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best examples of MVC Web Application and Software Designs by Neal Thomas",
                    Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "The Worlds Best MVC Web Designs in Tampa Bay by Neal Thomas .NET"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Web Applications by Neal Thomas",
                    SiteName = "Worlds Best Web Designs",
                    Title = "Worlds Best Web Application Design by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/web-apps/"
                }
            };

            return View(worldsBestResponse);
        }
        
        public ActionResult Breadcrumb() => PartialView();
        public ActionResult WebApps() => PartialView();
    }

    public class MobileAppsController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best MVC Mobile App Software by Neal Thomas",
                    Keywords = "Worlds Best Web Mobile App Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "The Worlds Best Mobile App Web Designs using MVC .NET in by Neal Thomas"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Mobile App Designs",
                    SiteName = "Worlds Best Web Designs",
                    Title = "Worlds Best Mobile Application Design by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/mobile-apps/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult MobileApps() => PartialView();
    }

    public class SeoController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best Web Search Engine Optimization Designs by Neal Thomas",
                    Keywords = "Worlds Best SEO Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "The Worlds Best Search Engine Optimizations Designs using MVC .NET in Tampa Bay by Neal Thomas"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Search Engine Optimization Designs",
                    SiteName = "Worlds Best Web Designs",
                    Title = "Worlds Best Search Engine Optimizations by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/search-engine-optimization/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult Seo() => PartialView();
    }

    public class BrandingController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best Company Branding by Neal Thomas",
                    Keywords = "Worlds Best Branding Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "The Worlds Best Company Branding Designs using MVC .NET in Tampa Bay by Neal Thomas"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Branding Software Designs",
                    SiteName = "Worlds Best Web Designs",
                    Title = "World's Best Branding Designs by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/branding/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult Branding() => PartialView();
    }

    public class AboutUsController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "All About the Worlds Best MVC Software Designer - Neal Thomas",
                    Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "Neal Thomas is the Worlds Best Web Designer using MVC .NET in Tampa Bay and the World"
                },
                OgData = new OgData
                {
                    Description = "Neal Thomas voted the Worlds Best Web and Software Designer in the World",
                    SiteName = "Worlds Best Web Designs",
                    Title = "World's Best Web Designs by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/about-us/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult AboutUs() => PartialView();
        public ActionResult MoreAboutUs() => PartialView();
    }

    public class ContactUsController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Contact the Worlds Best MVC Web Designer Neal Thomas",
                    Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "Contact Neal Thomas The Worlds Best Web Designer using MVC .NET in Tampa Bay by Neal Thomas"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Web and Software Designs",
                    SiteName = "Worlds Best Web Designs",
                    Title = "Contact the Worlds Best Web Designer Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/contact-me/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult ContactUs() => PartialView();
    }

    public class SiteTechnologyController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best MVC .NET Site Technology in Tampa Bay using Azure",
                    Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "Worlds Best MVC .NET Site Technology in Tampa Bay"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Web and Software Designs",
                    SiteName = "Worlds Best Web Designs",
                    Title = "World's Best Web Designs by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/site-technology/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult AboutThis() => PartialView();
    }

    public class PortfolioController : Controller
    {
        public ActionResult Index()
        {
            var worldsBestResponse = new WorldsBestResponse
            {
                SeoData = new SeoData
                {
                    Description = "Worlds Best MVC Web Designs and Software by Neal Thomas",
                    Keywords = "Worlds Best Web Designs,Neal Thomas,MVC Web Designs,Tampa Bay Web Designer",
                    Title = "The Worlds Best Web Designs using MVC .NET in Tampa Bay by Neal Thomas"
                },
                OgData = new OgData
                {
                    Description = "Worlds Best Web and Software Designs",
                    SiteName = "Worlds Best Web Designs",
                    Title = "World's Best Web Designs by Neal Thomas",
                    Type = "website",
                    Url = "https://www.worldsbestwebdesigns.com/portfolio/"
                }
            };

            return View(worldsBestResponse);
        }

        public ActionResult Breadcrumb() => PartialView();
        public ActionResult Portfolio() => PartialView();
        public ActionResult CallToAction() => PartialView();
    }
}