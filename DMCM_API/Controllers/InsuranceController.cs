
using BusinessAccessLayer.Services.insurance;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
        [Authorize(Roles = "Customer")]
        [HttpGet("/GetAgentDetails")]
        public IActionResult GetAgentDetails()
        {
            try
            {
                return Ok(_serviceInsurance.GetAgentDetails());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [Authorize(Roles = "Customer")]
        [HttpPost("/SubmitNominationDetails")]
        public IActionResult SubmitNominationDetails(Nomination nomination)
        {
            try
            {
                _serviceInsurance.InsertNomination(nomination);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
