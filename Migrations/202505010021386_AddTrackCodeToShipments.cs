namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrackCodeToShipments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.shimpentsses", "TrackCode", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.shimpentsses", "TrackCode");
        }
    }
}
