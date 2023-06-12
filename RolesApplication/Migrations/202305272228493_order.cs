namespace RolesApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class order : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Orders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userEmail = c.String(),
                        timeOrder = c.DateTime(nullable: false),
                        NameandQuant = c.String(nullable: false),
                        total = c.Double(nullable: false),
                        deliverystatus = c.String(),
                        tracking_num = c.String(nullable: false),
                        driverEmail = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
