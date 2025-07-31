namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class closesshipments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClothingShipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Color = c.String(nullable: false),
                        Size = c.String(nullable: false),
                        Weight = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        SpecialInstructions = c.String(),
                        ImageData = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClothingShipments", "UserID", "dbo.users");
            DropIndex("dbo.ClothingShipments", new[] { "UserID" });
            DropTable("dbo.ClothingShipments");
        }
    }
}
