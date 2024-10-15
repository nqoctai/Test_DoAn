using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_DoAn.Models;
using Test_DoAn.Filters;

namespace Test_DoAn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index()
        {
           
            LaptopShopDBContext db = new LaptopShopDBContext();
            List<Product> listProduct = db.Products.ToList();
            return View(listProduct);
        }

        public ActionResult Error404()
        {
            return View();
        }

       
    }
}