namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newrow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shipments", "price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shipments", "price");
        }
    }
}
