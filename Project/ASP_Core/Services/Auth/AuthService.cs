using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Responses;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ASP_Core.Services.Auth
{
    public interface AuthIService
    {
        public LoginResponse? Login(LoginModel loginModel);
    }


    public class AuthService : AuthIService
    {
        private readonly SaturnContext saturnContext;
        public AuthService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
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
            return userResponse;
        }
    }
}
