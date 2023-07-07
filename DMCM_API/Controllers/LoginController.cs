using BusinessAccessLayer.Services.Services.Login;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public string Login(Users user)
        {
            return _iServiceLogin.Authenticate(user.Username, user.Password);
        }
    }
}
