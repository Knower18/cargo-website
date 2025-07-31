namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delveryisses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryIssues",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        trackcode = c.String(nullable: false),
                        issue_type = c.String(nullable: false),
                        Decription = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeliveryIssues", "user_id", "dbo.users");
            DropIndex("dbo.DeliveryIssues", new[] { "user_id" });
            DropTable("dbo.DeliveryIssues");
        }
    }
}
