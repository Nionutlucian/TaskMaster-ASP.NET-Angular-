namespace TaskMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tasks", "EmployeeId");
            AddForeignKey("dbo.Tasks", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Tasks", new[] { "EmployeeId" });
            DropColumn("dbo.Tasks", "EmployeeId");
        }
    }
}
