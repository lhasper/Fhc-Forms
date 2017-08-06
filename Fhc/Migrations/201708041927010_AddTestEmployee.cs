namespace Fhc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestEmployee : DbMigration
    {
        public override void Up()
        {
            
            Sql("INSERT INTO Employees(FirstName, LastName, Title, DepartmentId, Supervisor, BuildingId, StartDate, UserName, Password, Domain, Epic, Dentrix, Email, Internet, Skype, PhoneExt, Laptop) VALUES('Mike', 'Jones', 'It Tech', '3', 'Ray Treb', '2', '01-01-2017', 'mjones', 'Password1', 'True', 'False', 'True', 'False', 'True', 'False', 'True', 'False')");


            }
        
        public override void Down()
        {
        }
    }
}
