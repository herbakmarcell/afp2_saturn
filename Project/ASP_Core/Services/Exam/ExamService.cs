using ASP_Core.Controllers;
using ASP_Core.Database;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Models.Responses.PUT;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace ASP_Core.Services.Exam
{
    public interface IExamService
    {
        public List<ExamModelResponse>? ListExams();
        public AddExamToUserResponse? AddExamToUser(AddExamUserModel userexam);
        public ExamModelResponse? AddNewExam(AddExamRequest createExamRequestModel);
        public ExamModelResponse? DeleteExam(int examId);
        public ExamModelResponse? EditExam(ExamRequest examModel);
        public ExamModelResponse? SearchExamById(int id);
        public List<ExamModelResponse>? SearchExamsByProf(string profid);
        public List<ExamModelResponse>? SearchExamsBySemester(int semesterId);
        public List<ExamModelResponse>? SearchExamsByCourse(string courseCode);
    }
    public class ExamService : IExamService
    {
        private readonly SaturnContext saturnContext;
        public ExamService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }

        public List<ExamModelResponse>? ListExams()
        {
            return saturnContext.ListExams();
        }

        public AddExamToUserResponse? AddExamToUser(AddExamUserModel examuser)
        {
            return saturnContext.AddExamToUser(examuser);
        }

        public ExamModelResponse? AddNewExam(AddExamRequest addExamRequest)
        {
            return saturnContext.AddNewExam(addExamRequest);
        }

        public ExamModelResponse? DeleteExam(int examId)
        {
            return saturnContext.DeleteExam(examId);
        }

        public ExamModelResponse? EditExam(ExamRequest examModel)
        {
            return saturnContext.EditExam(examModel);
        }

        public List<ExamModelResponse>? SearchExamsByProf(string prof)
        {
            return saturnContext.SearchExamsByProf(prof);
        }

        public ExamModelResponse? SearchExamById(int id)
        {
            return saturnContext.SearchExamById(id);
        }

        public List<ExamModelResponse>? SearchExamsByCourse(string courseCode)
        {
            return saturnContext.SearchExamByCourse(courseCode);
        }

        public List<ExamModelResponse>? SearchExamsBySemester(int semesterId)
        {
            return saturnContext.SearchExamBySemester(semesterId);
        }
    }
}
