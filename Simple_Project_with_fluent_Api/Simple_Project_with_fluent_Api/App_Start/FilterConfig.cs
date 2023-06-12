using System.Web;
using System.Web.Mvc;

namespace Simple_Project_with_fluent_Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
