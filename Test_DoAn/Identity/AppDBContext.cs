using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Test_DoAn.Identity
{
    public class AppDBContext : IdentityDbContext<AppUser>
    {
        public AppDBContext() : base("name=LaptopShopDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Đổi tên bảng AspNetUsers
            modelBuilder.Entity<AppUser>().ToTable("NguoiDung");

            // Đổi tên bảng AspNetRoles
            modelBuilder.Entity<IdentityRole>().ToTable("VaiTro");

            // Đổi tên bảng AspNetUserLogins
            modelBuilder.Entity<IdentityUserLogin>().ToTable("DangNhapNguoiDung");

            // Đổi tên bảng AspNetUserRoles
            modelBuilder.Entity<IdentityUserRole>().ToTable("VaiTroNguoiDung");



            modelBuilder.Entity<AppUser>().Property(e => e.UserName).HasColumnName("TenNguoiDung");
            modelBuilder.Entity<AppUser>().Property(e => e.Email).HasColumnName("Email");
            modelBuilder.Entity<AppUser>().Property(e => e.PasswordHash).HasColumnName("MatKhauMaHoa");
            modelBuilder.Entity<AppUser>().Property(e => e.PhoneNumber).HasColumnName("SoDienThoai");


            modelBuilder.Entity<IdentityRole>().Property(r => r.Name).HasColumnName("TenVaiTro");
        }
    }
}