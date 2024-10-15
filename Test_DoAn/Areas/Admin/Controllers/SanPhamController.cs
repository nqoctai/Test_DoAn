using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_DoAn.Models;
using Test_DoAn.Filters;

namespace Test_DoAn.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult BangSanPham()
        {
            LaptopShopDBContext db = new LaptopShopDBContext();
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}