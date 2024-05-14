using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
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
        private readonly CourseIService CourseService;
        private readonly ICommonService commonService;
        public CourseController(CourseIService courseService, ICommonService commonService)
        {
            this.CourseService = courseService;
            this.commonService = commonService;
        }

        [HttpPost]
        [Authorize()]
        [Route("addnewcourse")]
        public ActionResult<Response<NewCourseResponse>> AddnewCourse([FromBody] ListCourseModel courseModel)
        {
            NewCourseResponse newCourseResponse = CourseService.AddNewCourse(courseModel);
            if (newCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(newCourseResponse.Message));
            }
            return new OkObjectResult(new Response<NewCourseResponse>(newCourseResponse));
        }

        [HttpDelete]
        [Authorize()]
        [Route("deletecourse")]
        public ActionResult<Response<NewCourseResponse>> DeleteCourse([FromBody] string courseCode)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            NewCourseResponse newCourseResponse = CourseService.DeleteCourse(courseCode);
            if (newCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(newCourseResponse.Message));
            }
            return new OkObjectResult(new Response<NewCourseResponse>(newCourseResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("listcourses")]
        public ActionResult<Response<ListCourseResponse>> ListCourses()
        {
            ListCourseResponse listCourseResponse = CourseService.ListCourses();
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }


        [HttpPut]
        [Authorize()]
        [Route("editcourse")]
        public ActionResult<Response<NewCourseResponse>> EditCourse([FromBody] ListCourseModel courseModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            NewCourseResponse newCourseResponse = CourseService.EditCourse(courseModel);
            if (newCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(newCourseResponse.Message));
            }
            return new OkObjectResult(new Response<NewCourseResponse>(newCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbyprof")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesByProf([FromQuery] string profid)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesByProf(profid);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbycreditmin")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesByCreditmin([FromQuery] int credit)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesByCreditmin(credit);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }
    }
}
