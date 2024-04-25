using ASP_Core.Database.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Responses;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Security.Claims;

namespace ASP_Core.Services.Auth
{
    public interface ICommonService
    {
        public string TokenWithSaturn(IEnumerable<Claim> claims);
        public bool TokenHasRole(IEnumerable<Claim> claims, string role);
    }

    public class CommonService : ICommonService
    {
        public string TokenWithSaturn(IEnumerable<Claim> claims)
        {
            if (claims == null) return null;
            return claims.FirstOrDefault(c => c.Type == "saturnCode").Value.ToString();
        }

        public bool TokenHasRole(IEnumerable<Claim> claims, string role)
        {
            if (claims == null) return false;
            return claims.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Value.Split(',').Contains(role);
        }
    }
}
