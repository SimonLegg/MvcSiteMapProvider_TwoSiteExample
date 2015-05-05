using System.Web.Mvc;
using TwoSiteExample.MvcSiteMap.SiteMapHelper;

namespace TwoSiteExample.MvcSiteMap.Site1_aSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            // Add runtime info to the MvcSiteMapProvider
            var smr = new SiteMapResolver();
            smr.Resolve();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            // Add runtime info to the MvcSiteMapProvider
            var smr = new SiteMapResolver();
            smr.Resolve();

            return View();
        }
    }
}
