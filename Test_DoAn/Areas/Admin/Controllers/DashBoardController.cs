using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_DoAn.Filters;
using System.Diagnostics;

namespace Test_DoAn.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class DashBoardController : Controller
    {
        // GET: Admin/DashBoard
        [MyAuthenFilter]
        [MyActionFilter]
        [MyResultFilter]
        public ActionResult Index()
        {
            ViewBag.Number = 10;
            return View();
        }
    }
}