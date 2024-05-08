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
        [HttpPost]
        [Authorize()]
        [Route("addnewexam")]
        public ActionResult<Response<StandardExamResponse>> AddnewExam([FromBody]ExamModel examModel)
        {
            StandardExamResponse addNewExamResponse = examService.AddNewExam(examModel);
            if (addNewExamResponse.Success == false)
            {
                return BadRequest(new Response<string>(addNewExamResponse.Message));
            }
            return new OkObjectResult(new Response<StandardExamResponse>(addNewExamResponse.Message));
        }
        [HttpPost]
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
            return new OkObjectResult(new Response<StandardExamResponse>(StandardExamResponse.Message));
        }

        [HttpPost]
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
            return new OkObjectResult(new Response<StandardExamResponse>(StandardExamResponse.Message));
        }

        [HttpPost]
        [Authorize()]
        [Route("searchexamsbyprof")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsByProf([FromBody] string profname)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsByProf(profname);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse.Message));
        }

        [HttpPost]
        [Authorize()]
        [Route("searchexamsbyid")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsById([FromBody] int id)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsById(id);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse.Message));
        }


        [HttpPost]
        [Authorize()]
        [Route("searchexamsbySizeMin")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsBySizeMin([FromBody] int size)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsBySizeMin(size);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse.Message));
        }

        [HttpPost]
        [Authorize()]
        [Route("searchexamsbySizeMax")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsBySizeMax([FromBody] int size)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsBySizeMax(size);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse.Message));
        }



        [HttpPost]
        [Authorize()]
        [Route("searchexamsbycourse")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsByCourse([FromBody] string courseCode)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsByCourse(courseCode);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse.Message));
        }

        [HttpPost]
        [Authorize()]
        [Route("searchexamsbysemester")]
        public ActionResult<Response<ListExamsResponse>> SearchExamsBySemester([FromBody] int semesterId)
        {
            ListExamsResponse listExamsResponse = examService.SearchExamsBySemester(semesterId);
            if (listExamsResponse.Success == false)
            {
                return BadRequest(new Response<string>(listExamsResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(listExamsResponse.Message));
        }



        [HttpPost]
        [Authorize()]
        [Route("examusercount")]
        public ActionResult<Response<ExamUserCountResponse>> ExamUserCount([FromBody]int ExamId)
        {
            ExamUserCountResponse examUserCountResponse = examService.ExamUserCount(ExamId);
            if (examUserCountResponse.Success == false)
            {
                return BadRequest(new Response<string>(examUserCountResponse.Message));
            }
            return new OkObjectResult(new Response<ListExamsResponse>(examUserCountResponse.Message));
        }
    }
}
