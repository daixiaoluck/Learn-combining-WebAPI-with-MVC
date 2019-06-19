using System.Web;
using System.Web.Mvc;

namespace Learn_combining_WebAPI_with_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
