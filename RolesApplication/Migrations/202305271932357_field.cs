namespace RolesApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Cellnum", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Cellnum");
        }
    }
}
