namespace Fhc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedThingsUp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "FullTimeEmployeeId", "dbo.FullTimeEmployees");
            DropIndex("dbo.Employees", new[] { "FullTimeEmployeeId" });
            DropColumn("dbo.Employees", "FullTimeEmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "FullTimeEmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "FullTimeEmployeeId");
            AddForeignKey("dbo.Employees", "FullTimeEmployeeId", "dbo.FullTimeEmployees", "FullTimeEmployeeId", cascadeDelete: true);
        }
    }
}
