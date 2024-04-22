using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Responses;
using ASP_Core.Services.Auth;
using Elfie.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol;
using NuGet.Protocol.Plugins;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Composition;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ASP_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthIService authService;

        public AuthController(AuthIService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<Response<LoginResponse>> Login([FromBody] LoginModel loginModel)
        {
            var resource = authService.Login(loginModel);

            if (resource == null)
                return BadRequest(new Response<string>("Unauthorized"));

            return new OkObjectResult(new Response<LoginResponse>(resource));
        }

        [HttpPost]
        [Authorize()]
        [Route("register")]
        public ActionResult<Response<RegisterResponse>> Register([FromBody] RegisterModel registerModel)
        {
            if(!authService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            var registerResponse = authService.Register(registerModel);

            return new OkObjectResult(new Response<RegisterResponse>(registerResponse));
        }

        [HttpPost]
        [Authorize()]
        [Route("change")]
        public ActionResult<Response<ChangeResponse>> Change([FromBody] ChangeModel changeModel)
        {
            if (string.IsNullOrEmpty(changeModel.SaturnCode))
            {
                changeModel.SaturnCode = authService.TokenWithSaturn(User.Claims);
            }

            if (!authService.TokenHasRole(User.Claims, "Admin") && changeModel.SaturnCode != authService.TokenWithSaturn(User.Claims))
            {
                return BadRequest(new Response<string>("Can't change the others data without Admin permissions"));
            }
            if (!authService.TokenHasRole(User.Claims, "Admin") && changeModel.NewRoles != null)
            {
                return BadRequest(new Response<string>("Only Admin can change the roles"));
            }

            ChangeResponse? changeResponse = authService.Change(changeModel);

            if (changeResponse == null)
            {
                return BadRequest(new Response<string>("Unknown User or bad roles"));
            }
            return new OkObjectResult(new Response<ChangeResponse>(changeResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("user")]
        public ActionResult<Response<string>> GetUser([FromHeader] string saturnCode)
        {
            UserDataResponse userData;
            if (!authService.TokenHasRole(User.Claims, "Admin") )
            {
                User? user = authService.GetUser(authService.TokenWithSaturn(User.Claims));
                userData = new UserDataResponse
                {
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber
                };
                return new OkObjectResult(new Response<UserDataResponse>(userData));
            }
            else
            {
                saturnCode ??= authService.TokenWithSaturn(User.Claims);

                User? user = authService.GetUser(saturnCode);
                if (user == null)
                {
                    return BadRequest(new Response<string>("Nincs ilyen felhasználó!"));
                }
                userData = new UserDataResponse
                {
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber
                };
                return new OkObjectResult(new Response<UserDataResponse>(userData));
            }
            
            
        }

    }
}
