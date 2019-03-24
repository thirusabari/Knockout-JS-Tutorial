using System.Web;
using System.Web.Mvc;

namespace Add_And_Delete_Button
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}