using System.Web;
using System.Web.Mvc;

namespace BT2_3_DANGNGUYENHOAIDUY
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
