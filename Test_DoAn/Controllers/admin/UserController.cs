using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_DoAn.Models;

namespace Test_DoAn.Controllers.admin
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserTable()
        {
            LaptopShopDBContext db = new LaptopShopDBContext();
            List<User> users = db.Users.ToList();
            return View(users);
        }
    }
}