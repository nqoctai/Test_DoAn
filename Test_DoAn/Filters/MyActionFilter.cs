using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Test_DoAn.Filters
{
    public class MyActionFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.Number = 15;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
            filterContext.Controller.ViewBag.Number = 5;
        }
    }
}