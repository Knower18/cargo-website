namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class compnays : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cargocompanies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        company_name = c.String(nullable: false),
                        COMPNAYimg = c.Binary(),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateTime = c.DateTime(nullable: false),
                        DELIVERY_TIME = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cargocompanies");
        }
    }
}
