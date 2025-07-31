namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.pets",
                c => new
                    {
                        PetShipmentID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        PetName = c.String(nullable: false),
                        PetType = c.String(nullable: false),
                        Breed = c.String(),
                        Gender = c.String(),
                        MicrochipID = c.String(),
                        Age = c.Int(nullable: false),
                        Weight = c.Single(nullable: false),
                        SpecialInstructions = c.String(),
                        PetPhoto = c.Binary(),
                        HealthDocument = c.Binary(),
                    })
                .PrimaryKey(t => t.PetShipmentID)
                .ForeignKey("dbo.users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.pets", "UserID", "dbo.users");
            DropIndex("dbo.pets", new[] { "UserID" });
            DropTable("dbo.pets");
        }
    }
}
