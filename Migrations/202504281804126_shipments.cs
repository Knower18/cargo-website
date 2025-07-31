namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shipments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.shimpentsses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        USER_ID = c.Int(nullable: false),
                        cargo_id = c.Int(nullable: false),
                        shipment_type = c.String(),
                        statuse = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        cargoimg = c.Binary(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cargocompanies", t => t.cargo_id, cascadeDelete: true)
                .ForeignKey("dbo.users", t => t.USER_ID, cascadeDelete: true)
                .Index(t => t.USER_ID)
                .Index(t => t.cargo_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.shimpentsses", "USER_ID", "dbo.users");
            DropForeignKey("dbo.shimpentsses", "cargo_id", "dbo.cargocompanies");
            DropIndex("dbo.shimpentsses", new[] { "cargo_id" });
            DropIndex("dbo.shimpentsses", new[] { "USER_ID" });
            DropTable("dbo.shimpentsses");
        }
    }
}
