using ASP_Core.Models;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Models.Responses.POST;
using ASP_Core.Models.Responses.PUT;
using ASP_Core.Services.Auth;
using ASP_Core.Services.Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Core.Controllers
{
    public class ExamController : ControllerBase
    {
        private readonly IExamService examService;
        private readonly ICommonService commonService;
        public ExamController(IExamService examService, ICommonService commonService)
        {
            this.examService = examService;
            this.commonService = commonService;
        }
       
        [HttpPost]
        [Authorize()]
        [Route("addexamtouser")]
        public ActionResult<Response<AddExamToUserResponse>> AddExamToUser([FromBody] AddExamUserModel examUser)
        {
            if (!commonService.TokenHasRole(User.Claims,"Admin") && examUser.SaturnCode != commonService.TokenWithSaturn(User.Claims))
            {
                return Unauthorized(new Response<string>("Nem tud felvenni másnak vizsgát admin nélkül!"));
            }
            AddExamToUserResponse? addExamToUserResponse = examService.AddExamToUser(examUser);
            if (addExamToUserResponse == null)
            {
                return BadRequest(new Response<string>("Hiba a vizsga felvétele közben!"));
            }
            return new OkObjectResult(new Response<AddExamToUserResponse>(addExamToUserResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("listexams")]
        public ActionResult<Response<List<ExamModelResponse>>> ListExams()
        {
            List<ExamModelResponse>? listExamsResponse = examService.ListExams();
            if (listExamsResponse == null)
            {
                return BadRequest(new Response<string>("Nincsennek vizsgák!"));
            }
            return new OkObjectResult(new Response<List<ExamModelResponse>>(listExamsResponse));
        }

        [HttpPost]
        [Authorize()]
        [Route("addnewexam")]
        public ActionResult<Response<ExamModelResponse>> AddnewExam([FromBody] AddExamRequest createExamRequestModel)
        {
            ExamModelResponse? response = examService.AddNewExam(createExamRequestModel);
            if (response == null)
            {
                return BadRequest(new Response<string>("Sikertelen vizsga hozzáadása!"));
            }
            return new OkObjectResult(new Response<ExamModelResponse>(response));
        }

        [HttpDelete]
        [Authorize()]
        [Route("deleteexam")]
        public ActionResult<Response<ExamModelResponse>> DeleteExam([FromBody] int examId)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin") && !commonService.TokenHasRole(User.Claims, "Teacher"))
            {
                return Unauthorized(new Response<string>("Hiányzó jogosultságok!"));
            }
            ExamModelResponse? response = examService.DeleteExam(examId);
            if (response == null)
            {
                return BadRequest(new Response<string>("Sikertelen vizsga törlése!"));
            }
            return new OkObjectResult(new Response<ExamModelResponse>(response));
        }

        [HttpPut]
        [Authorize()]
        [Route("editexam")]
        public ActionResult<Response<ExamModelResponse>> EditExam([FromBody] ExamRequest examModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin") || !commonService.TokenHasRole(User.Claims, "Teacher"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            ExamModelResponse? response = examService.EditExam(examModel);
            if (response == null)
            {
                return BadRequest(new Response<string>("Sikertelen vizsga szerkesztés!"));
            }
            return new OkObjectResult(new Response<ExamModelResponse>(response));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbyprof")]
        public ActionResult<Response<List<ExamModelResponse>>> SearchExamsByProf([FromQuery] string profid)
        {
            List <ExamModelResponse> response = examService.SearchExamsByProf(profid);
            if (response == null)
            {
                return BadRequest(new Response<string>("Nincsen vizsga ehhez a professzorhoz!"));
            }
            return new OkObjectResult(new Response<List<ExamModelResponse>>(response));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbyid")]
        public ActionResult<Response<ExamModelResponse>> SearchExamById([FromQuery] int id)
        {
            ExamModelResponse? response = examService.SearchExamById(id);
            if (response == null)
            {
                return BadRequest(new Response<string>("Nincs vizsga ezzel az ID-val!"));
            }
            return new OkObjectResult(new Response<ExamModelResponse>(response));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbycourse")]
        public ActionResult<Response<List<ExamModelResponse>>> SearchExamsByCourse([FromQuery] string courseCode)
        {
            List<ExamModelResponse> response = examService.SearchExamsByCourse(courseCode);
            if (response == null)
            {
                return BadRequest(new Response<string>("Ennek a kurzusnak nincsennek vizsgái!"));
            }
            return new OkObjectResult(new Response<List<ExamModelResponse>>(response));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchexamsbysemester")]
        public ActionResult<Response<List<ExamModelResponse>>> SearchExamsBySemester([FromQuery] int semesterId)
        {
            List<ExamModelResponse> response = examService.SearchExamsBySemester(semesterId);
            if (response == null)
            {
                return BadRequest(new Response<string>("Ebben a szemeszterben még nincsennek vizsgák!"));
            }
            return new OkObjectResult(new Response<List<ExamModelResponse>>(response));
        }
    }
}
