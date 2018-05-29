using System.Web;
using System.Web.Mvc;

namespace JuliusA.MyFirstADFSWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
