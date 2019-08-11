using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskMaster.Models;

namespace TaskMaster.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        private readonly TaskMasterDBContext _taskMasterDBContext = new TaskMasterDBContext();

        // GET api/Employee
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return _taskMasterDBContext.Employees.ToList();
        }
    }
}