using BusinessAccessLayer.Services.Services.medicare;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("/ServicesPlanNames")]

        public List<string> GetPlanResult()
        {
            return _serviceMedicare.GetPlanNames();
        }

        [HttpGet("/ServicesPlanDetails")]
        public List <medservice> GetPlanDetails(string planName) 
        {
            return _serviceMedicare.GetPlanDetails(planName);
        }
    }
}
