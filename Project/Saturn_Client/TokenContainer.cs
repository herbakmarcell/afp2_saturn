using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.IdentityModel.Tokens;

namespace Saturn_Client
{
    public static class TokenContainer
    {
        public static string? Token {  get; set; }
        public static bool IsAdmin
        {
            get
            {

                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(Token);

                var claims = jwtToken.Claims;

                return claims.FirstOrDefault(c => c.Type == "roles").Value.Split(',').Contains("Admin");
            }
        }

        public static string? GetSaturnCode {
            get
            {

                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(Token);

                var claims = jwtToken.Claims;

                return claims.FirstOrDefault(c => c.Type == "saturnCode").Value.ToString();
            }
        }
    }
}
