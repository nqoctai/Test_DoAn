namespace Test_DoAn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserAttributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FullName", c => c.String());
            AddColumn("dbo.Users", "Phone", c => c.String());
            AddColumn("dbo.Users", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Address");
            DropColumn("dbo.Users", "Phone");
            DropColumn("dbo.Users", "FullName");
        }
    }
}
