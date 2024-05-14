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

namespace ASP_Core.Services.Course
{
    public interface CourseIService
    {
        public string TokenWithSaturn(IEnumerable<Claim> claims);
        public bool TokenHasRole(IEnumerable<Claim> claims, string role);
        public NewCourseResponse? AddNewCourse(ListCourseModel courseModel);
        public NewCourseResponse? DeleteCourse(string courseCode);
        public NewCourseResponse? EditCourse(ListCourseModel courseModel);
        public ListCourseResponse? ListCourses();
        public ListCourseResponse? SearchCoursesByProf(string profId);
        public ListCourseResponse? SearchCoursesByCreditmin(int credit);
    }
    public class CourseService : CourseIService
    {
        private readonly SaturnContext saturnContext;
        public CourseService(SaturnContext saturnContext)
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
        public NewCourseResponse? AddNewCourse(ListCourseModel courseModel)
        {
            return saturnContext.AddNewCourse(courseModel);
        }

        public NewCourseResponse? DeleteCourse(string courseCode)
        {
            return saturnContext.DeleteCourse(courseCode);
        }

        public ListCourseResponse? ListCourses()
        {
            return saturnContext.ListCourses();
        }

        public NewCourseResponse? EditCourse(ListCourseModel courseModel)
        {
            return saturnContext.EditCourse(courseModel);
        }

        public ListCourseResponse? SearchCoursesByProf(string profId)
        {
            return saturnContext.SearchCoursesByProf(profId);
        }

        public ListCourseResponse? SearchCoursesByCreditmin(int credit)
        {
            return saturnContext.SearchCoursesByCreditmin(credit);
        }
    }
}
