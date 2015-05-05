using System.Web.Mvc;

namespace TwoSiteExample.MvcSiteMap.Site1_aSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}