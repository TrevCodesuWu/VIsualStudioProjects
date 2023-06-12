using System.Web;
using System.Web.Mvc;

namespace RestuarantApplication_03_03_2023
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
