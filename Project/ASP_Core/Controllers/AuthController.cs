using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Responses;
using Elfie.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ASP_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SaturnContext saturnContext;

        public AuthController(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<Response<LoginResponse>> Login([FromBody] LoginModel loginModel)
        {
            User user = saturnContext.LoginCheck(loginModel.SaturnCode, loginModel.Password);

            if (user == null)
            {
                return BadRequest(new Response<string>("Unauthorized"));
            }

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SaturnSuperSecretKey666XDWEARETHECHAMPIONSMYFRIEND"));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                {
                    new Claim("saturnCode", user.SaturnCode)
                };

                var tokenOptions = new JwtSecurityToken(
                    issuer: "https://localhost:7204/",
                    audience: "https://localhost:7204/",
                    claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: signingCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                LoginResponse userResponse = new LoginResponse
                {
                    Token = tokenString,
                    SaturnCode = user.SaturnCode,
                    Password = user.Password,
                };

            if (userResponse == null)
                return BadRequest(new Response<string>("Unauthorized"));

            return new OkObjectResult(new Response<LoginResponse>(userResponse));
        }
    }
}
