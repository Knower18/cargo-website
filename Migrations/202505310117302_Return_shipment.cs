namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Return_shipment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.retunshipments", "trackcode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.retunshipments", "trackcode");
        }
    }
}
