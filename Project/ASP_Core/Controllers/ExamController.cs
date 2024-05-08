﻿using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
using ASP_Core.Services.Auth;
using ASP_Core.Services.Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Core.Controllers
{
    public class ExamController : ControllerBase
    {
        private readonly ExamIService examService;
        private readonly ICommonService commonService;
        public ExamController(ExamIService examService, ICommonService commonService)
        {
            this.examService = examService;
            this.commonService = commonService;
        }
       
        [HttpPost]
        [Authorize()]
        [Route("addexamtouser")]
        public ActionResult<Response<AddExamToUserResponse>> AddExamToUser([FromBody] ExamUserModel examuser)
        {
            if (examuser.SaturnCode==null || examuser.ExamId==null)
            {
                return BadRequest(new Response<string>("Hibás adatok "));
            }
            AddExamToUserResponse? addExamToUserResponse = examService.AddExamToUser(examuser);
            if (addExamToUserResponse.Success==false)
            {
                return BadRequest(new Response<string>(addExamToUserResponse.Message));
            }
            return new OkObjectResult(new Response<AddExamToUserResponse>(addExamToUserResponse));
        }

        [HttpPost]
        [Authorize()]
        [Route("listexams")]
        public ActionResult<Response<ListExamsResponse>> ListExams()
        {
            ListExamsResponse listExamsResponse = examService.ListExams();
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse.Message));
        }
    }
}