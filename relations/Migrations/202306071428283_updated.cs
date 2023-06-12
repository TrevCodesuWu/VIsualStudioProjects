namespace relations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Rooms", new[] { "CompanyId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Companies");
        }
    }
}
