namespace Test_DoAn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateModuleProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Image = c.String(),
                        DetailDesc = c.String(),
                        ShortDesc = c.String(),
                        Quantity = c.Long(nullable: false),
                        Sold = c.Long(nullable: false),
                        Brand = c.String(),
                        Target = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
