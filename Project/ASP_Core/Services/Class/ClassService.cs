using ASP_Core.Controllers;
using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Responses;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace ASP_Core.Services.Exam
{
    public interface ClassIService
    {
        public string TokenWithSaturn(IEnumerable<Claim> claims);
        public bool TokenHasRole(IEnumerable<Claim> claims, string role);

        public StandardClassResponse? AddNewClass(CreateClassRequestModel createClassRequestModel);
        public StandardClassResponse? DeleteClass(int classId);
        public StandardClassResponse? EditClass(EditClassModel editClassModel);
    }
    public class ClassService : ClassIService
    {
        private readonly SaturnContext saturnContext;
        public ClassService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }


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

        public StandardClassResponse? AddNewClass(CreateClassRequestModel createClassRequestModel)
        {
            return saturnContext.AddNewClass(createClassRequestModel);
        }

        public StandardClassResponse? DeleteClass(int classId)
        {
            return saturnContext.DeleteClass(classId);
        }

        public StandardClassResponse? EditClass(EditClassModel editClassModel)
        {
            return saturnContext.EditClass(editClassModel);
        }
    }
}