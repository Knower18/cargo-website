namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class senderr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Senders",
                c => new
                    {
                        SenderID = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(maxLength: 20),
                        Email = c.String(maxLength: 100),
                        NationalID = c.String(maxLength: 20),
                        PickupAddress = c.String(maxLength: 255),
                        City = c.String(maxLength: 50),
                        State = c.String(maxLength: 50),
                        PostalCode = c.String(maxLength: 20),
                        Country = c.String(maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SenderID)
                .ForeignKey("dbo.users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Senders", "user_id", "dbo.users");
            DropIndex("dbo.Senders", new[] { "user_id" });
            DropTable("dbo.Senders");
        }
    }
}
