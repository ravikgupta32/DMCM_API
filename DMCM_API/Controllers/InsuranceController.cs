
using BusinessAccessLayer.Services.insurance;
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
        public readonly IServiceInsurance _serviceInsurance;
        public InsuranceController(IServiceInsurance serviceInsurance)
        {
            _serviceInsurance = serviceInsurance;
        }

        [HttpGet("/GetAgentDetails")]
        public List<Agent> GetAgentDetails()
        {
            return _serviceInsurance.GetAgentDetails(); 
        }
        [HttpPost("/SubmitNominationDetails")]
        public void SubmitNominationDetails(Nomination nomination) 
        { 
           _serviceInsurance.InsertNomination(nomination);
        }
    }
}
