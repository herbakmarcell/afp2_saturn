using ASP_Core.Database;
using ASP_Core.Models;
using ASP_Core.Models.Course;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Services.Auth;
using ASP_Core.Services.Course;
using ASP_Core.Services.Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Core.Controllers
{
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;
        private readonly ICommonService commonService;
        public CourseController(ICourseService courseService, ICommonService commonService)
        {
            this.courseService = courseService;
            this.commonService = commonService;
        }

        [HttpPost]
        [Authorize()]
        [Route("addnewcourse")]
        public ActionResult<Response<CourseResponse>> AddnewCourse([FromBody] CourseRequest courseModel)
        {
            CourseResponse? newCourseResponse = courseService.AddNewCourse(courseModel);
            if (newCourseResponse == null)
            {
                return BadRequest(new Response<string>("Sikertelen kurzus létrehozás"));
            }
            return new OkObjectResult(new Response<CourseResponse>(newCourseResponse));
        }

        [HttpDelete]
        [Authorize()]
        [Route("deletecourse")]
        public ActionResult<Response<CourseResponse>> DeleteCourse(string courseCode)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin") && !commonService.TokenHasRole(User.Claims, "Teacher"))
            {
                return Unauthorized(new Response<string>("Nincs megfelelő jogosultság!"));
            }
            CourseResponse? newCourseResponse = courseService.DeleteCourse(courseCode);
            if (newCourseResponse == null)
            {
                return BadRequest(new Response<string>("Sikertelen kurzus törlés!"));
            }
            return new OkObjectResult(new Response<CourseResponse>(newCourseResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("listcourses")]
        public ActionResult<Response<List<CourseModel>>> ListCourses()
        {
            List<CourseModel> courses = courseService.ListCourses();
            if (courses == null)
            {
                return BadRequest(new Response<string>("Nincs kurzus!"));
            }
            return new OkObjectResult(new Response<List<CourseModel>>(courses));
        }


        [HttpPut]
        [Authorize()]
        [Route("editcourse")]
        public ActionResult<Response<CourseResponse>> EditCourse([FromBody] CourseRequest courseModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin") && !commonService.TokenHasRole(User.Claims, "Teacher"))
            {
                return Unauthorized(new Response<string>("Hiányzó jogosultság!"));
            }
            CourseResponse? newCourseResponse = courseService.EditCourse(courseModel);
            if (newCourseResponse == null)
            {
                return BadRequest(new Response<string>("Hiba a kurzus szerkesztése során!"));
            }
            return new OkObjectResult(new Response<CourseResponse>(newCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbyprof")]
        public ActionResult<Response<List<CourseModel>>> SearchCoursesByProf(string profid)
        {
            List<CourseModel> listCourseResponse = courseService.SearchCoursesByProf(profid);
            if (listCourseResponse == null)
            {
                return BadRequest(new Response<string>("Nem találhatóak kurzusok ehhez a professzorhoz!"));
            }
            return new OkObjectResult(new Response<List<CourseModel>>(listCourseResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbycredit")]
        public ActionResult<Response<List<CourseModel>>> SearchCoursesByCredit(bool byMax, int credit)
        {
            List<CourseModel> listCourseResponse = courseService.SearchCoursesByCredit(byMax, credit);
            if (listCourseResponse == null)
            {
                return BadRequest(new Response<string>("Ennek a keresésnek semmi front-endje, de sikeresen meghívtad :)"));
            }
            return new OkObjectResult(new Response<List<CourseModel>>(listCourseResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbytype")]
        public ActionResult<Response<List<CourseModel>>> SearchCoursesByType(string type)
        {
            List<CourseModel> listCourseResponse = courseService.SearchCoursesByType(type);
            if (listCourseResponse == null)
            {
                return BadRequest(new Response<string>("Nincsennek ilyen típusú kurzusok!"));
            }
            return new OkObjectResult(new Response<List<CourseModel>>(listCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbysemester")]
        public ActionResult<Response<List<CourseModel>>> SearchCoursesBySemester(int semesterId)
        {
            List<CourseModel> listCourseResponse = courseService.SearchCoursesBySemester(semesterId);
            if (listCourseResponse == null)
            {
                return BadRequest(new Response<string>("Ebben a szemeszterben nincsennek kurzusok!"));
            }
            return new OkObjectResult(new Response<List<CourseModel>>(listCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbysubject")]
        public ActionResult<Response<List<CourseModel>>> SearchCoursesBySubject(string subjectCode)
        {
            List<CourseModel> listCourseResponse = courseService.SearchCoursesBySubject(subjectCode);
            if (listCourseResponse == null)
            {
                return BadRequest(new Response<string>("Ennek a tárgynak nincsennek kurzusai!"));
            }
            return new OkObjectResult(new Response<List<CourseModel>>(listCourseResponse));
        }
    }
}
