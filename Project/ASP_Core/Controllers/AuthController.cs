using ASP_Core.Database;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //private readonly UserManager<IdentityUser> userManager;
        //private readonly RoleManager<IdentityRole> roleManager;
        private readonly SaturnContext saturnContext;

        public AuthController(SaturnContext saturnContext)
        {
            //this.userManager = userManager;
            //this.roleManager = roleManager;
            this.saturnContext = saturnContext;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<Response> Login([FromBody] LoginModel loginModel)
        {
            if (saturnContext.UserExistsWithPassword(loginModel.SaturnCode, loginModel.Password))
            {
                return new Response() { Code = 0 , Message = "Sikeres bejelentkezés!"};
            }
            return new Response() { Code = -1, Message = "Hibás felhasználónév vagy jelszó!" };
        }
    }
}
