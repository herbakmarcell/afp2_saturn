using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Models.Responses.POST;
using ASP_Core.Models.Responses.PUT;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace ASP_Core.Services.Auth
{
    public interface AuthIService
    {
        public User? GetUser(string saturnCode);
        public LoginResponse? Login(LoginModel loginModel);
        public RegisterResponse? Register(RegisterModel registerModel);
        public ChangeResponse? Change(ChangeModel changeModel);
        
    }


    public class AuthService : AuthIService
    {
        private readonly SaturnContext saturnContext;
        public AuthService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }

        public User? GetUser(string saturnCode)
        {
            return saturnContext.UserWithSaturnCode(saturnCode);
        }
        public LoginResponse? Login(LoginModel loginModel)
        {
            User? user = saturnContext.LoginCheck(loginModel.SaturnCode, loginModel.Password);

            if (user == null)
            {
                return null;
            }

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SaturnSuperSecretKey666XDWEARETHECHAMPIONSMYFRIEND"));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                    new Claim("saturnCode", user.SaturnCode),
                    new Claim("roles",user.ReturnRoles)
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
            return userResponse;
        }

        public RegisterResponse? Register(RegisterModel registerModel)
        {
            if (registerModel.Roles == null)
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -1,
                    Message = "Valamilyen jogkörnek kell lennie!"
                };
            }

            string registerString = saturnContext.Register(registerModel);

            if (registerModel == null)
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -101,
                    Message = "Váratlan hiba"
                };
            }

            return new RegisterResponse
            {
                SaturnCode = registerString,
                Code = 0,
                Message = "Sikeres regisztráció!"
            };

        }

        public ChangeResponse? Change(ChangeModel changeModel)
        {
            return saturnContext.UserChange(changeModel);
            
        }

        

        
    }
}
