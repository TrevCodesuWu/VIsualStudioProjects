namespace relations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Companies");
            DropTable("dbo.Employees");
            DropTable("dbo.Rooms");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        telephone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
    }
}
