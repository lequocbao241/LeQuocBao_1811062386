using System.Web;
using System.Web.Mvc;

namespace LeQuocBao_1811062386
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
