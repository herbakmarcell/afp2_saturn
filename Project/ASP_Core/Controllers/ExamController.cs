using ASP_Core.Database.Models;
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

        [HttpGet]
        [Authorize()]
        [Route("listexams")]
        public ActionResult<Response<ListExamsResponse>> ListExams()
        {
            ListExamsResponse listExamsResponse = examService.ListExams();
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse));
        }
        [HttpPost]
        [Authorize()]
        [Route("addnewexam")]
        public ActionResult<Response<StandardExamResponse>> AddnewExam([FromBody]CreateExamRequestModel createExamRequestModel)
        {
            StandardExamResponse addNewExamResponse = examService.AddNewExam(createExamRequestModel);
            if (addNewExamResponse.Success == false)
            {
                return BadRequest(new Response<string>(addNewExamResponse.Message));
            }
            return new OkObjectResult(new Response<StandardExamResponse>(addNewExamResponse));
        }
        [HttpDelete]
        [Authorize()]
        [Route("deleteexam")]
        public ActionResult<Response<StandardExamResponse>> DeleteExam([FromBody] int examId)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            StandardExamResponse StandardExamResponse = examService.DeleteExam(examId);
            if (StandardExamResponse.Success == false)
            {
                return BadRequest(new Response<string>(StandardExamResponse.Message));
            }
            return new OkObjectResult(new Response<StandardExamResponse>(StandardExamResponse));
        }

        [HttpPut]
        [Authorize()]
        [Route("editexam")]
        public ActionResult<Response<StandardExamResponse>> EditExam([FromBody] ExamModel examModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            StandardExamResponse StandardExamResponse = examService.EditExam(examModel);
            if (StandardExamResponse.Success == false)
            {
                return BadRequest(new Response<string>(StandardExamResponse.Message));
            }
            return new OkObjectResult(new Response<StandardExamResponse>(StandardExamResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbyprof")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsByProf([FromQuery] string profid)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsByProf(profid);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbyid")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsById([FromQuery] int id)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsById(id);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchexamsbySizeMin")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsBySizeMin([FromQuery] int size)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsBySizeMin(size);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbySizeMax")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsBySizeMax([FromQuery] int size)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsBySizeMax(size);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse));
        }



        [HttpGet]
        [Authorize()]
        [Route("searchexamsbycourse")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsByCourse([FromQuery] string courseCode)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsByCourse(courseCode);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<ListExamsResponse>(listExamsResponse));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbysemester")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsBySemester([FromQuery] int semesterId)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsBySemester(semesterId);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse));
        }



        [HttpGet]
        [Authorize()]
        [Route("examusercount")]
        public ActionResult<Response<ExamUserCountResponse>> ExamUserCount([FromQuery]int ExamId)
        {
            ExamUserCountResponse examUserCountResponse = examService.ExamUserCount(ExamId);
            if (examUserCountResponse.Success == false)
            {
                return BadRequest(new Response<string>(examUserCountResponse.Message));
            }
            return new OkObjectResult(new Response<ExamUserCountResponse>(examUserCountResponse));
        }
    }
}
