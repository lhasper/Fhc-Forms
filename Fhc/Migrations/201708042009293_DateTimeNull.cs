namespace Fhc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "StartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
