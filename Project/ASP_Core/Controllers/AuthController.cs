﻿using ASP_Core.Database;
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
            if(!authService.RolesFromToken(User.Claims).Contains("Admin"))
            {
                return BadRequest(new Response<string>("Missing Admin permission"));
            }

            var registerResponse = authService.Register(registerModel);

            if (registerResponse.Code != 0)
            {
                return BadRequest(new Response<string>(registerResponse.Message));
            }
            return new OkObjectResult(new Response<RegisterResponse>(registerResponse));
        }
    }
}
