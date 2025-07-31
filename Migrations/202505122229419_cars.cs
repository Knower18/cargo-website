namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.caritems",
                c => new
                    {
                        CarItemID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        VehicleType = c.String(nullable: false, maxLength: 50),
                        Make = c.String(nullable: false, maxLength: 50),
                        Model = c.String(nullable: false, maxLength: 50),
                        Year = c.String(maxLength: 10),
                        VIN = c.String(maxLength: 50),
                        PlateNumber = c.String(maxLength: 20),
                        Color = c.String(maxLength: 20),
                        PhotoPath = c.Binary(),
                    })
                .PrimaryKey(t => t.CarItemID)
                .ForeignKey("dbo.users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.caritems", "UserID", "dbo.users");
            DropIndex("dbo.caritems", new[] { "UserID" });
            DropTable("dbo.caritems");
        }
    }
}
