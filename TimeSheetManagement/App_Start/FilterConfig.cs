using System.Web;
using System.Web.Mvc;
using TimeSheetManagement.Helpers;

namespace TimeSheetManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
           filters.Add(new ErrorLoggerAttribute());
        }
    }
}
