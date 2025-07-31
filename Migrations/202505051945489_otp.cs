namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.otps",
                c => new
                    {
                        ResetID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        ResetCode = c.String(),
                        ExpirationTime = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResetID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.otps");
        }
    }
}
