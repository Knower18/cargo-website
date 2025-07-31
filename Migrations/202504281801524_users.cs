namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class users : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        email = c.String(nullable: false, maxLength: 255),
                        password = c.String(),
                        phone = c.String(),
                        kamlik = c.String(),
                        profileimg = c.Binary(),
                        isadmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.email, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.users", new[] { "email" });
            DropTable("dbo.users");
        }
    }
}
