using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3.Models;


namespace Project3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalystController : ControllerBase
    {
        private readonly AnalystContext analystContext;
        public AnalystController(AnalystContext analystContext)
        {
            this.analystContext = analystContext;
        }
        [HttpGet]
        [Route("GetAssignedTasks")]
        public List<SystemAnalyst> GetSystemAnalysts()
        {
            return analystContext.SystemAnalysts.ToList();
            
        }
        [HttpGet]
        [Route("GetAssignedTaks")]
        public SystemAnalyst GetSystemAnalyst(string username)
        {
            return analystContext.SystemAnalysts.Where(x => x.Username == username).FirstOrDefault();
        }

        [HttpPut]
        [Route("UpdateTaks")]
        public string UpdateTask(SystemAnalyst systemAnalyst) 
            {
            analystContext.Entry(systemAnalyst).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            analystContext.SaveChanges();
            return "Task successfully updated.";
            }
    }
}
