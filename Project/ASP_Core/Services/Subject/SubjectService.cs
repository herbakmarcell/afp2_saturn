using ASP_Core.Controllers;
using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Responses.DELETE;
using ASP_Core.Models.Subject;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace ASP_Core.Services.Subject
{
    public interface ISubjectService
    { 
        public List<SubjectResponse>? ListSubjects();
        public SubjectResponse? AddNewSubject(SubjectModel subject);
        public DeleteSubjectResponse? DeleteSubject(string subjectCode);
        public SubjectResponse? EditSubject(SubjectModel subject);
    }
    public class SubjectService : ISubjectService
    {
        private readonly SaturnContext saturnContext;
        public SubjectService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }

        public List<SubjectResponse>? ListSubjects()
        {
            return saturnContext.ListSubjects();
        }

        public SubjectResponse? AddNewSubject(SubjectModel subject)
        {
            return saturnContext.AddNewSubject(subject);
        }

        public DeleteSubjectResponse? DeleteSubject(string subjectCode)
        {
            return saturnContext.DeleteSubject(subjectCode);
        }

        public SubjectResponse? EditSubject(SubjectModel subject)
        {
            return saturnContext.EditSubject(subject);
        }
    }
}
