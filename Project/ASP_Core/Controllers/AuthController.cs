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
using NuGet.Protocol.Plugins;
using System;
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

        //[HttpPost]
        //[Route("register")]
        //[AllowAnonymous]
        //public async Task<ActionResult<Response<string>>> Register([FromBody] RegisterModel registerModel)
        //{
        //    User userExists;
        //    string generatedSaturnCode = "";
        //    do
        //    {
                

        //        Random rd = new Random();
        //        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        //        for (int i = 0; i < 6; i++)
        //        {
        //            generatedSaturnCode+= chars[rd.Next(chars.Length)];
        //        }

        //        userExists = saturnContext.Users.FirstOrDefault(u =>  u.SaturnCode == generatedSaturnCode);
        //    } while (userExists !=null);


        //    User user = new User();
        //    user.SaturnCode = generatedSaturnCode;
        //    user.Password = BCrypt.Net.BCrypt.HashPassword(registerModel.Password);
        //    user.LastName = registerModel.LastName;
        //    user.FirstName = registerModel.FirstName;
        //    user.Email = registerModel.Email;
        //    user.PhoneNumber =registerModel.PhoneNumber;
        //    Role role = new Role();
        //    role.Name = "Hallgató";
        //    user.Roles = new List<Role>();
        //    user.Roles.Add(role);

            
        //    var newUser = await saturnContext.Register(user);

        //    if (newUser == null)
        //        return BadRequest(new Response<string>("Hiba a felhasználó létrehozásakor!"));

        //    return new OkObjectResult(new Response<string>($"Sikeres regisztráció! Most már bejelentkezhet!\nAz ön Saturn kódja:\n{generatedSaturnCode}"));
        //}
    }
}
