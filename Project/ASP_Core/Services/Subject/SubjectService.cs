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

namespace ASP_Core.Services.Subject
{
    public interface SubjectIService
    {
        public string TokenWithSaturn(IEnumerable<Claim> claims);
        public bool TokenHasRole(IEnumerable<Claim> claims, string role);

        public ListSubjectResponse? ListSubjects();
        public ListSubjectResponse? AddNewSubject(SubjectModel subject);
        public ListSubjectResponse? DeleteSubject(string subjectCode);
        public ListSubjectResponse? EditSubject(SubjectModel subject);
    }
    public class SubjectService : SubjectIService
    {
        private readonly SaturnContext saturnContext;
        public SubjectService(SaturnContext saturnContext)
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

        public ListSubjectResponse? ListSubjects()
        {
            return saturnContext.ListSubjects();
        }

        public ListSubjectResponse? AddNewSubject(SubjectModel subject)
        {
            return saturnContext.AddNewSubject(subject);
        }

        public ListSubjectResponse? DeleteSubject(string subjectCode)
        {
            return saturnContext.DeleteSubject(subjectCode);
        }

        public ListSubjectResponse? EditSubject(SubjectModel subject)
        {
            return saturnContext.EditSubject(subject);
        }
    }
}
