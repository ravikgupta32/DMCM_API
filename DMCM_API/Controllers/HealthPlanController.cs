using BusinessAccessLayer.Models;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HealthPlanController : ControllerBase
    {
        HealthPlanRepository hepo = new HealthPlanRepository();
        [HttpGet("/GetPlanNames")]
        public IActionResult GetPlanName()
        {
            List<string> planNames = hepo.GetPlanNames();
            return Ok(planNames);
        }
        [HttpGet("/GetPlanDetails")]
        public IActionResult GetPlanDetails(string name) { 
            List<HealthPlan> health = hepo.GetHealthPlanDetails(name);
            return Ok(health);
        }
    }
}
