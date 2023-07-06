using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;


using DataAccessLayer.DataAccess;

using DataAccessLayer.Models;
using BusinessAccessLayer.Services.result;
using DataAccessLayer.Contracts;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewResultsController : ControllerBase
    {
        public IServiceResult _iServiceResult;
        public ViewResultsController(IServiceResult iServiceResult)
        {
            _iServiceResult = iServiceResult;
        }

        [HttpGet("/ViewReports")]
        public List<Report> GetResults()
        {
            return _iServiceResult.ViewReport();
        }
    }
}
