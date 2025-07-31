namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Return_shipments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.retunshipments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userid = c.Int(nullable: false),
                        shipmentid = c.Int(nullable: false),
                        type = c.String(),
                        reason = c.String(),
                        image = c.Binary(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Shipments", t => t.shipmentid, cascadeDelete: true)
                .ForeignKey("dbo.users", t => t.userid)
                .Index(t => t.userid)
                .Index(t => t.shipmentid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.retunshipments", "userid", "dbo.users");
            DropForeignKey("dbo.retunshipments", "shipmentid", "dbo.Shipments");
            DropIndex("dbo.retunshipments", new[] { "shipmentid" });
            DropIndex("dbo.retunshipments", new[] { "userid" });
            DropTable("dbo.retunshipments");
        }
    }
}
