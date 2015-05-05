using System.Web.Mvc;
using TwoSiteExample.MvcSiteMap.SiteMapHelper;

namespace TwoSiteExample.MvcSiteMap.Site2_otherSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            // Add runtime info to the MvcSiteMapProvider
            var smr = new SiteMapResolver();
            smr.Resolve();

            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Home page.";

            // Add runtime info to the MvcSiteMapProvider
            var smr = new SiteMapResolver();
            smr.Resolve();

            return View();
        }
    }
}
