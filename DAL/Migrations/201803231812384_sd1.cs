namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sd1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Price = c.Single(nullable: false),
                        Description = c.String(nullable: false, maxLength: 500),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NickName = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 200),
                        Phone = c.Int(nullable: false),
                        Money = c.Single(nullable: false),
                        Products_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Products_Id)
                .Index(t => t.Products_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Products_Id", "dbo.Products");
            DropIndex("dbo.Users", new[] { "Products_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
        }
    }
}
