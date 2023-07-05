
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        InsuranceRepository insurancerp = new InsuranceRepository();
        [HttpGet("/GetAgentDetails")]
        public IActionResult GetAgentDetails()
        {
            List<Agent> details = insurancerp.GetAgentDetails();
            return Ok(details);
        }
        [HttpPost("/SubmitNominationDetails")]
        public IActionResult SubmitNominationDetails(Nomination nomination) 
        { 
            insurancerp.InsertNomination(nomination);
            return Ok("Nomination Details Submitted");
        }
    }
}
