using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace ASP_Core.Services.Auth
{
    public interface AuthIService
    {
        public LoginResponse? Login(LoginModel loginModel);
        public RegisterResponse? Register(RegisterModel registerModel);
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

        public RegisterResponse? Register(RegisterModel registerModel)
        {
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            string passwordPattern = @"^.{3,16}$";
            string lastNamePattern = @"^[a-záéóöőúüűA-ZÁÉÓÖŐÚÜŰ.]+$";
            string firstNamePattern = @"^[a-záéóöőúüűA-ZÁÉÓÖŐÚÜŰ.]+$";
            string phonePattern = @"^\+\d{11}$";

            Role? adminRole = saturnContext.Roles.FirstOrDefault(r => r.Name == "Admin" && r.User.SaturnCode == registerModel.AdminSaturnCode);
            if (adminRole == null)
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -100,
                    Message = "Nem rendelkezik a megfelelő jogosultsággal!"
                };
            }

            if (!Regex.IsMatch(registerModel.Email, emailPattern))
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -1,
                    Message = "Email formátuma nem megfelelő!"
                };
            }

            if (!Regex.IsMatch(registerModel.Password, passwordPattern))
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -2,
                    Message = "A jelszó formátuma nem megfelelő!"
                };
            }

            if (!Regex.IsMatch(registerModel.LastName, lastNamePattern))
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -3,
                    Message = "Utónév csak betűből állhat!"
                };
            }

            if (!Regex.IsMatch(registerModel.FirstName, firstNamePattern))
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -4,
                    Message = "Vezetéknév csak betűből állhat!"
                };
            }

            if (!Regex.IsMatch(registerModel.PhoneNumber, phonePattern))
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -5,
                    Message = "Telefonszám formátuma nem megfelelő!"
                };
            }

            if (registerModel.Roles == null)
            {
                return new RegisterResponse
                {
                    SaturnCode = null,
                    Code = -6,
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
    }
}
