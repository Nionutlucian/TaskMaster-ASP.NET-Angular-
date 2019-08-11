using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskMaster.Models;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TaskMaster.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class TaskController : ApiController
    {
        private readonly TaskMasterDBContext _taskMasterDBContext = new TaskMasterDBContext();

        //GET api/task
        [HttpGet]
        public IHttpActionResult GetTasks()
        {
            var tasks = _taskMasterDBContext.Tasks;
           
            return Ok(tasks);
        }

        //GET api/task/{id}
        [HttpGet]
        public IHttpActionResult GetTask(int id)
        {
            Task task = _taskMasterDBContext.Tasks.Find(id);
            
            if(task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        //POST api/task
        [HttpPost]
        public IHttpActionResult CreateTask(Task task)
        {
            if (task.Name == null || task.StatusId.GetType() != typeof(int)  || task.EmployeeId.GetType() != typeof(int))
            {
                return BadRequest();
            }
            _taskMasterDBContext.Tasks.Add(task);
            _taskMasterDBContext.SaveChanges();
            return Ok();
        }

        //PUT api/task
        [HttpPut]
        public IHttpActionResult UpdateTask(Task task)
        {
            var existingTask = _taskMasterDBContext.Tasks.Find(task.Id);

            if (existingTask == null)
            {
                return NotFound();
            }

            existingTask.Id = task.Id;
            existingTask.Name = task.Name;
            existingTask.StatusId = task.StatusId;
            existingTask.EmployeeId = task.EmployeeId;

            _taskMasterDBContext.SaveChanges();

            return Ok();
        }

        //DELETE api/task/{id}
        public IHttpActionResult DeleteTask(int id)
        {
            var existingTask = _taskMasterDBContext.Tasks.Find(id);

            if (existingTask == null)
            {
                return NotFound();
            }

            _taskMasterDBContext.Tasks.Remove(existingTask);
            _taskMasterDBContext.SaveChanges();

            return Ok();
        }
    }
}