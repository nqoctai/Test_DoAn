using System;
using System.Web;
using System.Web.Mvc;
using Test_DoAn.Filters;

namespace Test_DoAn
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new MyExceptionFilter());
            filters.Add(new HandleErrorAttribute() { ExceptionType = typeof(Exception), View = "Error"});
        }
    }
}
