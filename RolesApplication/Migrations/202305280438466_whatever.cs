namespace RolesApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class whatever : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userEmail = c.String(nullable: false),
                        trackingnum = c.String(nullable: false),
                        deliverystatus = c.String(),
                        DriversId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Drivers", t => t.DriversId)
                .Index(t => t.DriversId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "DriversId", "dbo.Drivers");
            DropIndex("dbo.Orders", new[] { "DriversId" });
            DropTable("dbo.Orders");
        }
    }
}
