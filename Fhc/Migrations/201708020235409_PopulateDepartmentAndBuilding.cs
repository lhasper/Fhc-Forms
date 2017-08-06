namespace Fhc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartmentAndBuilding : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Administration')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Behavioral Health')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Billing')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Clinical Operations')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Clinical Srvs')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Community Mental Health')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Dental')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Facilities')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Ferris State')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Human Resources')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Medical')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Medical Records')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Nurses')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Occupational Therapy')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Outreach')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Patient Registration')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Physical Therapy')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Providers')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('Quality')");
            Sql("INSERT INTO Departments (DepartmentName) VALUES('WMED')");
            Sql("INSERT INTO Buildings (BuildingName) VALUES('Alcott')");
            Sql("INSERT INTO Buildings (BuildingName) VALUES('Burdick')");
            Sql("INSERT INTO Buildings (BuildingName) VALUES('KCMH')");
            Sql("INSERT INTO Buildings (BuildingName) VALUES('Mobile Dental')");
            Sql("INSERT INTO Buildings (BuildingName) VALUES('Mobile Medical')");
            Sql("INSERT INTO Buildings (BuildingName) VALUES('Paterson')");
            Sql("INSERT INTO Buildings (BuildingName) VALUES('Sheridan')");
            }
        
        public override void Down()
        {
        }
    }
}
