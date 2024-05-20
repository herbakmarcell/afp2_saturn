using ASP_Core.Controllers;
using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Class;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Services.Auth;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace ASP_Core.Services.Exam
{
    public interface IClassService
    {
        public ClassResponse? AddClass(AddClassRequest addClassRequest);
        public ClassResponse? DeleteClass(int classId);
        public ClassResponse? EditClass(EditClassRequest? editClassModel);
        public ClassResponse? SearchClassesById(int? id);
        public List<ClassResponse?> SearchClassesByTime(bool byStart, bool byMin, DateTime startTime);
    }
    public class ClassService : IClassService
    {
        private readonly SaturnContext saturnContext;
        public ClassService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }

        public ClassResponse? AddClass(AddClassRequest addClassRequest)
        {
            return saturnContext.AddClass(addClassRequest);
        }

        public ClassResponse? DeleteClass(int classId)
        {
            return saturnContext.DeleteClass(classId);
        }

        public ClassResponse? EditClass(EditClassRequest? editClassModel)
        {
            if (editClassModel == null)
            {
                return null;
            }
            return saturnContext.EditClass(editClassModel);
        }

        public ClassResponse? SearchClassesById(int? id)
        {
            if (id == null) return null;
            ClassModel? searchedClass = saturnContext.SearchClassById(id);
            if (searchedClass == null) return null;
            ClassResponse result = new ClassResponse
            {
                Id = searchedClass.Id,
                StartTime = searchedClass.StartTime,
                EndTime = searchedClass.EndTime,
                Course = searchedClass.Course.Code,
                Room = searchedClass.Room.Code
            };
            return result;
        }

        public List<ClassResponse?> SearchClassesByTime(bool byStart, bool byMin, DateTime time)
        {
            List<ClassModel> temp = saturnContext.SearchClassByTime(byMin, byStart, time);
            if (temp == null || temp.Count == 0) return null;
            List<ClassResponse> result = temp.Select(c => new ClassResponse
            {
                Id = c.Id,
                StartTime = c.StartTime,
                EndTime = c.EndTime,
                Course = c.Course.Type,
                Room = c.Room.Code
            }).ToList();
            return result;
        }

    }
}
