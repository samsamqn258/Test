using System.Web;
using System.Web.Mvc;

namespace DangAnhVu_2180603744_BUOI2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
