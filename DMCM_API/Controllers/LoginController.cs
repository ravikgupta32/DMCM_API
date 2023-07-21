using BusinessAccessLayer.Services.Services.Login;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Diagonstic_Medicare_Centre_Managment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IServiceLogin _iServiceLogin;
        public LoginController(IServiceLogin iServiceLogin)
        {
            _iServiceLogin = iServiceLogin;
        }
        [HttpPost("/Login")]
        public IActionResult Login(Users user)
        {
            try
            {
                if (_iServiceLogin.Authenticate(user.Username, user.Password) == "User Does not exists")
                    return StatusCode((int)HttpStatusCode.Unauthorized,"User does not exists.");

                return Ok(_iServiceLogin.Authenticate(user.Username, user.Password));
            }
            catch (Exception ex) {
               
                return BadRequest(ex.Message);
            }
        }
    }
}
