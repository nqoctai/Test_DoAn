using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_DoAn.Identity;
using Test_DoAn.Filters;

namespace Test_DoAn.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class NguoiDungController : Controller
    {
        // GET: Admin/NguoiDung
        public ActionResult Index()
        {
            AppDBContext db = new AppDBContext();
            List<AppUser> listUser = db.Users.ToList();
            return View(listUser);
        }
    }
}