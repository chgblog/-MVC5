using System.Web;
using System.Web.Mvc;

namespace CHG.Web.UI_TongHua
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
