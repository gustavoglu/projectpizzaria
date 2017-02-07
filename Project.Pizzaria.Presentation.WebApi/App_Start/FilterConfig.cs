using System.Web;
using System.Web.Mvc;

namespace Project.Pizzaria.Presentation.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
