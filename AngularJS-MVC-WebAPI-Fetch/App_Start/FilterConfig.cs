using System.Web;
using System.Web.Mvc;

namespace AngularJS_MVC_WebAPI_Fetch
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
