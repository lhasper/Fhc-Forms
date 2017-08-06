namespace Fhc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestEmployee1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees(FirstName, LastName, Title, DepartmentId, Supervisor, BuildingId, StartDate, UserName, Password, Domain, Epic, Dentrix, Email, Internet, Skype, PhoneExt, Laptop) VALUES('Tim', 'Baker', 'It Tech', '1', 'Ray Treb', '3', '02-12-2017', 'mjones', 'Password1', 'True', 'False', 'True', 'False', 'True', 'False', 'True', 'False')");
            }
        
        public override void Down()
        {
        }
    }
}
