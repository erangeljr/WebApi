using System.Net.Http;
using System.Web.Http;
using WebApi.Web.Common.Routing;
using WebApi.Web.Api.Models;

namespace WebApi.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        [Route("", Name = "AddTaskRoute")]
        [HttpPost]
        public Task AddTask(HttpRequestMessage requestMessage, Task newTask)
        {
            return new Task
            {
                Subject = "In V1, newTask.Subject = " + newTask.Subject
            };
        }
    }
}
