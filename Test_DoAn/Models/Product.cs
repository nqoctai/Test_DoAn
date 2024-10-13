using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Test_DoAn.Models
{
    public class Product
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public string DetailDesc { get; set; }

        public string ShortDesc { get; set; }

        public long Quantity { get; set; }
        public long Sold { get; set; }
        public string Brand { get; set; }
        public string Target { get; set; }

    }
}