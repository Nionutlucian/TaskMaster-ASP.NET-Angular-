namespace TaskMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToEmployee : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees (FullName) VALUES ('Nicolescu Ionut')");
            Sql("INSERT INTO Employees (FullName) VALUES ('Manea Marius')");
            Sql("INSERT INTO Employees (FullName) VALUES ('Manescu Alexandru')");
            Sql("INSERT INTO Employees (FullName) VALUES ('Ostroveanu Madalin')");
        }
        
        public override void Down()
        {
        }
    }
}
