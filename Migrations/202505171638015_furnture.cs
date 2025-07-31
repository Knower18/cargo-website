namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class furnture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.funts",
                c => new
                    {
                        FurnitureItemID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        FurnitureType = c.String(),
                        Color = c.String(),
                        Length = c.Single(nullable: false),
                        Width = c.Single(nullable: false),
                        Height = c.Single(nullable: false),
                        Weight = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.FurnitureItemID)
                .ForeignKey("dbo.users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.funts", "UserID", "dbo.users");
            DropIndex("dbo.funts", new[] { "UserID" });
            DropTable("dbo.funts");
        }
    }
}
