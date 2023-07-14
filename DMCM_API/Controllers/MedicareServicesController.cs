using BusinessAccessLayer.Services.Services.medicare;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicareServicesController : ControllerBase
    {

        public IServiceMedicare _serviceMedicare;
        public MedicareServicesController(IServiceMedicare serviceMedicare)
        {
            _serviceMedicare = serviceMedicare;
        }
        [Authorize(Roles = "Customer")]
        [HttpGet("/ServicesPlanNames")]
        
        public IActionResult GetPlanResult()
        {
            try
            {
                return Ok( _serviceMedicare.GetPlanNames());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [Authorize(Roles = "Customer")]
        [HttpGet("/ServicesPlanDetails")]
        public IActionResult  GetPlanDetails(string planName) 
        {
            try
            {
                return Ok( _serviceMedicare.GetPlanDetails(planName));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
