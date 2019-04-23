using System.Web;
using System.Web.Mvc;

namespace _2_Vidly_Uing_Entity_Framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
