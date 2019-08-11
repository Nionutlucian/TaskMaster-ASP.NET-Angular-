using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMaster.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}