using System.Web;
using System.Web.Mvc;

namespace SAE_KYSI_PLEDGE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}