using System.Web.Mvc;

namespace TwoSiteExample.MvcSiteMap.Site2_otherSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}