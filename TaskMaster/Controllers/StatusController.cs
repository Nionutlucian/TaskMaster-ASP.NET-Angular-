using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskMaster.Models;

namespace TaskMaster.Controllers
{
    /// <summary>
    /// Controller for Status
    /// </summary>
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class StatusController : ApiController
    {
        private readonly TaskMasterDBContext _taskMasterDBContext = new TaskMasterDBContext();

        public StatusController() { }

        [HttpGet]
        public IEnumerable<Status> GetStatuses()
        {
            return _taskMasterDBContext.Statuses.ToList();
        }
    }
}