namespace Test_DoAn.IdentityMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viethoa : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetRoles", newName: "VaiTro");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "VaiTroNguoiDung");
            RenameTable(name: "dbo.AspNetUsers", newName: "NguoiDung");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "DangNhapNguoiDung");
            RenameColumn(table: "dbo.VaiTro", name: "Name", newName: "TenVaiTro");
            RenameColumn(table: "dbo.NguoiDung", name: "PasswordHash", newName: "MatKhauMaHoa");
            RenameColumn(table: "dbo.NguoiDung", name: "PhoneNumber", newName: "SoDienThoai");
            RenameColumn(table: "dbo.NguoiDung", name: "UserName", newName: "TenNguoiDung");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.NguoiDung", name: "TenNguoiDung", newName: "UserName");
            RenameColumn(table: "dbo.NguoiDung", name: "SoDienThoai", newName: "PhoneNumber");
            RenameColumn(table: "dbo.NguoiDung", name: "MatKhauMaHoa", newName: "PasswordHash");
            RenameColumn(table: "dbo.VaiTro", name: "TenVaiTro", newName: "Name");
            RenameTable(name: "dbo.DangNhapNguoiDung", newName: "AspNetUserLogins");
            RenameTable(name: "dbo.NguoiDung", newName: "AspNetUsers");
            RenameTable(name: "dbo.VaiTroNguoiDung", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.VaiTro", newName: "AspNetRoles");
        }
    }
}
