namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class papsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentShipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        DocumentType = c.String(nullable: false, maxLength: 100),
                        Weight = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        SpecialInstructions = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentShipments", "user_id", "dbo.users");
            DropIndex("dbo.DocumentShipments", new[] { "user_id" });
            DropTable("dbo.DocumentShipments");
        }
    }
}
