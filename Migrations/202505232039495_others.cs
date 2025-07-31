namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class others : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Others",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ItemTitle = c.String(),
                        Description = c.String(),
                        Weight = c.Single(),
                        Dimensions = c.String(),
                        ImageData = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Others", "UserID", "dbo.users");
            DropIndex("dbo.Others", new[] { "UserID" });
            DropTable("dbo.Others");
        }
    }
}
