using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test_DoAn.Models
{
    public class User
    {
        [Key]
        public long ID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

    }
}