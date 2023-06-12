namespace RolesApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Drivers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DriverEmail = c.String(nullable: false),
                        cellnum = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
        }
    }
}
