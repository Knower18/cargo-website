namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.adresses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        street_adress = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zipcode = c.String(),
                        country = c.String(),
                        userid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.users", t => t.userid, cascadeDelete: true)
                .Index(t => t.userid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.adresses", "userid", "dbo.users");
            DropIndex("dbo.adresses", new[] { "userid" });
            DropTable("dbo.adresses");
        }
    }
}
