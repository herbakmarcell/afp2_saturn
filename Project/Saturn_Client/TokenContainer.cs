using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace Saturn_Client
{
    public static class TokenContainer
    {
        public static string? Token {  get; set; }
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
