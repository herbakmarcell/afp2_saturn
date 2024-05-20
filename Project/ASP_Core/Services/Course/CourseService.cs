using ASP_Core.Controllers;
using ASP_Core.Database;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Course;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Responses.GET;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace ASP_Core.Services.Course
{
    public interface ICourseService
    {
        public CourseResponse? AddNewCourse(CourseRequest courseModel);
        public CourseResponse? DeleteCourse(string courseCode);
        public CourseResponse? EditCourse(CourseRequest courseModel);
        public List<CourseModel> ListCourses();
        public List<CourseModel> SearchCoursesByProf(string profId);
        public List<CourseModel> SearchCoursesByCredit(bool byMax, int credit);
        public List<CourseModel> SearchCoursesByType(string type);
        public List<CourseModel> SearchCoursesBySemester(int semesterId);
        public List<CourseModel> SearchCoursesBySubject(string subjectCode);
    }
    public class CourseService : ICourseService
    {
        private readonly SaturnContext saturnContext;
        public CourseService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }

        public CourseResponse? AddNewCourse(CourseRequest courseRequest)
        {
            return saturnContext.AddNewCourse(courseRequest);
        }

        public CourseResponse? DeleteCourse(string courseCode)
        {
            return saturnContext.DeleteCourse(courseCode);
        }

        public List<CourseModel> ListCourses()
        {
            return saturnContext.ListCourses();
        }

        public CourseResponse? EditCourse(CourseRequest courseRequest)
        {
            return saturnContext.EditCourse(courseRequest);
        }

        public List<CourseModel> SearchCoursesByProf(string profId)
        {
            return saturnContext.SearchCoursesByProf(profId);
        }

        public List<CourseModel> SearchCoursesByCredit(bool byMax, int credit)
        {
            return saturnContext.SearchCoursesByCredit(byMax, credit);
        }

        public List<CourseModel> SearchCoursesByType(string type)
        {
            return saturnContext.SearchCoursesByType(type);
        }

        public List<CourseModel> SearchCoursesBySemester(int semesterId)
        {
            return saturnContext.SearchCoursesBySemester(semesterId);
        }

        public List<CourseModel> SearchCoursesBySubject(string subjectCode)
        {
            return saturnContext.SearchCoursesBySubject(subjectCode);
        }
    }
}
