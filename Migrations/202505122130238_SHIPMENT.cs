namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SHIPMENT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        ShipmentID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        SenderID = c.Int(nullable: false),
                        ReceiverID = c.Int(nullable: false),
                        CargoCompanyID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        Status = c.String(),
                        truck_code = c.String(),
                        logo_company = c.Binary(),
                        lcatigory_image = c.Binary(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ShipmentID)
                .ForeignKey("dbo.cargocompanies", t => t.CargoCompanyID, cascadeDelete: true)
                .ForeignKey("dbo.Rechivers", t => t.ReceiverID)
                .ForeignKey("dbo.Senders", t => t.SenderID)
                .ForeignKey("dbo.users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.SenderID)
                .Index(t => t.ReceiverID)
                .Index(t => t.CargoCompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shipments", "UserID", "dbo.users");
            DropForeignKey("dbo.Shipments", "SenderID", "dbo.Senders");
            DropForeignKey("dbo.Shipments", "ReceiverID", "dbo.Rechivers");
            DropForeignKey("dbo.Shipments", "CargoCompanyID", "dbo.cargocompanies");
            DropIndex("dbo.Shipments", new[] { "CargoCompanyID" });
            DropIndex("dbo.Shipments", new[] { "ReceiverID" });
            DropIndex("dbo.Shipments", new[] { "SenderID" });
            DropIndex("dbo.Shipments", new[] { "UserID" });
            DropTable("dbo.Shipments");
        }
    }
}
