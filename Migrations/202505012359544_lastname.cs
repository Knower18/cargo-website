namespace WebApplication27.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "lasname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "lasname");
        }
    }
}
