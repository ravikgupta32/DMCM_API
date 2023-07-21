
using BusinessAccessLayer.Services.healthplan;
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

    public class HealthPlanController : ControllerBase
    {
        public readonly IServiceHealthPlan _iHealthPlan;
        public HealthPlanController(IServiceHealthPlan iHealthPlan) 
        { 
            _iHealthPlan = iHealthPlan;
        }
        [Authorize(Roles = "Customer")]
        [HttpGet("/GetPlanNames")]
        public IActionResult GetPlanName()
        {
            try
            {
                return Ok(_iHealthPlan.GetPlanNames());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [Authorize(Roles = "Customer")]
        [HttpGet("/GetPlanDetails")]
        public IActionResult GetPlanDetails(string name)
        {
            try
            {
                return Ok(_iHealthPlan.GetHealthPlanDetails(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
