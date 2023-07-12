using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;


using DataAccessLayer.DataAccess;

using DataAccessLayer.Models;
using BusinessAccessLayer.Services.result;
using DataAccessLayer.Contracts;
using System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ViewResultsController : ControllerBase
    {
        public IServiceResult _iServiceResult;
        public ViewResultsController(IServiceResult iServiceResult)
        {
            _iServiceResult = iServiceResult;
        }
        [Authorize(Roles = "Doctor,Customer")]
        [HttpGet("/ViewReports")]
        public List<Report> GetResults()
        {
            return _iServiceResult.ViewReport();
        }
    }
}
