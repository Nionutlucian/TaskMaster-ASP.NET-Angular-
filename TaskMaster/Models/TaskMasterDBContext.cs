using System.Data.Entity;

namespace TaskMaster.Models
{
    public class TaskMasterDBContext : DbContext
    {
        public TaskMasterDBContext() : base("name=TaskMasterDBContext")
        {

        }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}