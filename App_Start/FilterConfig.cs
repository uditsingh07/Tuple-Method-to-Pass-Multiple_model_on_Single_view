using System.Web;
using System.Web.Mvc;

namespace Tuple_Method_to_Pass_Multiple_model_on_Single_view
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
