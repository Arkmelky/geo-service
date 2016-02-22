using System.Web;
using System.Web.Mvc;

namespace Soloveyko_A_V_Geo_Service
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}