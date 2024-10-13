using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Test_DoAn.Models
{
    public class LaptopShopDBContext : DbContext
    {
        public LaptopShopDBContext() : base("name=LaptopShopDBContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}