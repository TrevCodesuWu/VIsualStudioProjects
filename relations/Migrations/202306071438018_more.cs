namespace relations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class more : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        telephone = c.String(nullable: false),
                        company_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Companies", t => t.company_id)
                .Index(t => t.company_id);
            
            AddColumn("dbo.Companies", "EmployeeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "company_id", "dbo.Companies");
            DropIndex("dbo.Employees", new[] { "company_id" });
            DropColumn("dbo.Companies", "EmployeeId");
            DropTable("dbo.Employees");
        }
    }
}
