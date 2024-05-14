﻿using ASP_Core.Database.Models;
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
    }
}
