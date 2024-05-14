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


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbycreditmax")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesByCreditmax([FromQuery] int credit)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesByCreditmax(credit);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbysizemin")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesBySizemin([FromQuery] int size)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesBySizemin(size);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbysizemax")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesBySizemax([FromQuery] int size)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesBySizemax(size);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbytype")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesByType([FromQuery] string type)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesByType(type);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbysemester")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesBySemester([FromQuery] int semesterId)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesBySemester(semesterId);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchcoursesbysubject")]
        public ActionResult<Response<ListCourseResponse>> SearchCoursesBySubject([FromQuery] string subjectCode)
        {
            ListCourseResponse listCourseResponse = CourseService.SearchCoursesBySubject(subjectCode);
            if (listCourseResponse.Success == false)
            {
                return BadRequest(new Response<string>(listCourseResponse.Message));
            }
            return new OkObjectResult(new Response<ListCourseResponse>(listCourseResponse));
        }
    }
}
