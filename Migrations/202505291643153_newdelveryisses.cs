namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdelveryisses : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DeliveryIssues", "trackcode", c => c.String());
            AlterColumn("dbo.DeliveryIssues", "issue_type", c => c.String());
            AlterColumn("dbo.DeliveryIssues", "Decription", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DeliveryIssues", "Decription", c => c.String(nullable: false));
            AlterColumn("dbo.DeliveryIssues", "issue_type", c => c.String(nullable: false));
            AlterColumn("dbo.DeliveryIssues", "trackcode", c => c.String(nullable: false));
        }
    }
}
