using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorldsBestWebDesigns.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult flexiSlider()
        {
            return PartialView();
        }

        public ActionResult tagLine()
        {
            return PartialView();
        }

        public ActionResult intro()
        {
            return PartialView();
        }

        public ActionResult sliderAd()
        {
            return PartialView();
        }

        public ActionResult recentProjects()
        {
            return PartialView();
        }

        public ActionResult principalServices()
        {
            return PartialView();
        }

        public ActionResult ourClients()
        {
            return PartialView();
        }
    }

    public class CommonController : Controller
    {
        public ActionResult footer() => PartialView();
        public ActionResult navbar() => PartialView();
        public ActionResult scripts() => PartialView();
    }

    public class WebDesignController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult responsiveWebDesigns() => PartialView();
    }

    public class SoftwareDesignController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult softwareDesign() => PartialView();
    }

    public class WebAppsController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult webApps() => PartialView();
    }

    public class MobileAppsController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult mobileApps() => PartialView();
    }

    public class SEOController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult SEO() => PartialView();
    }

    public class BrandingController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult branding() => PartialView();
    }

    public class PortfolioController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult portfolio() => PartialView();
        public ActionResult callToAction() => PartialView();
    }

    public class AboutUsController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult aboutUs() => PartialView();
        public ActionResult moreAboutUs() => PartialView();
    }

    public class ContactUsController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult contactUs() => PartialView();
    }

    public class SiteTechnologyController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult breadcrumb() => PartialView();
        public ActionResult aboutThis() => PartialView();
    }
}