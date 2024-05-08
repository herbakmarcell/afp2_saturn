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
    public interface ExamIService
    {
        public string TokenWithSaturn(IEnumerable<Claim> claims);
        public bool TokenHasRole(IEnumerable<Claim> claims, string role);
        public AddExamToUserResponse? AddExamToUser(ExamUserModel userexam);
        public ListExamsResponse? ListExams();
        public ListExamsResponse? SearchExamsByProf(string profname);
        public ListExamsResponse? SearchExamsById(int id);
        public StandardExamResponse? AddNewExam(ExamModel examModel);
        public StandardExamResponse? DeleteExam(int examId);
        public StandardExamResponse? EditExam(ExamModel examModel);
    }
    public class ExamService : ExamIService
    {
        private readonly SaturnContext saturnContext;
        public ExamService(SaturnContext saturnContext)
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
        public AddExamToUserResponse? AddExamToUser(ExamUserModel examuser)
        {
            
            if (examuser== null)
            {
                return new AddExamToUserResponse
                {
                    Message = "váratlan hiba",
                    StudentSaturnCode = examuser.SaturnCode,
                    Success = false,
                    ExamsId = examuser.ExamId
                };
            }
            if (examuser.ExamId == null)
            {
                return new AddExamToUserResponse
                {
                    Message = "váratlan hiba",
                    StudentSaturnCode = examuser.SaturnCode,
                    Success = false,
                    ExamsId = examuser.ExamId
                };
            }
            if (examuser.SaturnCode == null)
            {
                return new AddExamToUserResponse
                {
                    Message = "váratlan hiba",
                    StudentSaturnCode = examuser.SaturnCode,
                    Success = false,
                    ExamsId = examuser.ExamId
                };
            }
            saturnContext.AddExamToUser(examuser);
            return new AddExamToUserResponse
            {
                Message = "sikeres lefutás",
                StudentSaturnCode = examuser.SaturnCode,
                Success = true,
                ExamsId = examuser.ExamId
            };
        }

        public ListExamsResponse? ListExams()
        {
            return saturnContext.ListExams();
        }

        public StandardExamResponse? AddNewExam(ExamModel examModel)
        {
            return saturnContext.AddNewExams(examModel);
        }

        public StandardExamResponse? DeleteExam(int examId)
        {
            return saturnContext.DeleteExam(examId);
        }

        public StandardExamResponse? EditExam(ExamModel examModel)
        {
            return saturnContext.EditExam(examModel);
        }

        public ListExamsResponse? SearchExamsByProf(string profname)
        {
            return saturnContext.SearchExamByProf(profname);
        }

        public ListExamsResponse? SearchExamsById(int id)
        {
            return saturnContext.SearchExamById(id);
        }
    }
}
