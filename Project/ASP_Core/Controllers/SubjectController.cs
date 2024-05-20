using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Subject;
using ASP_Core.Services.Auth;
using ASP_Core.Services.Exam;
using ASP_Core.Services.Subject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Core.Controllers
{
    public class SubjectController : ControllerBase
    {
        private readonly SubjectIService subjectService;
        private readonly ICommonService commonService;
        public SubjectController(SubjectIService subjectService, ICommonService commonService)
        {
            this.subjectService =subjectService;
            this.commonService = commonService;
        }

        [HttpGet]
        [Authorize()]
        [Route("listsubjects")]
        public ActionResult<Response<ListSubjectResponse>> ListSubjects()
        {
            ListSubjectResponse listSubjectResponse = subjectService.ListSubjects();
            if (listSubjectResponse.Success == false)
            {
                return BadRequest(new Response<string>(listSubjectResponse.Message));
            }
            return new OkObjectResult(new Response<ListSubjectResponse>(listSubjectResponse));
        }

        [HttpPost]
        [Authorize()]
        [Route("addnewsubject")]
        public ActionResult<Response<ListSubjectResponse>> AddnewSubject([FromBody] SubjectModel subject)
        {
            ListSubjectResponse listSubjectResponse = subjectService.AddNewSubject(subject);
            if (listSubjectResponse.Success == false)
            {
                return BadRequest(new Response<string>(listSubjectResponse.Message));
            }
            return new OkObjectResult(new Response<ListSubjectResponse>(listSubjectResponse));
        }


        [HttpDelete]
        [Authorize()]
        [Route("deletesubject")]
        public ActionResult<Response<ListSubjectResponse>> DeleteSubject([FromBody] string subjectCode)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            ListSubjectResponse listSubjectResponse = subjectService.DeleteSubject(subjectCode);
            if (listSubjectResponse.Success == false)
            {
                return BadRequest(new Response<string>(listSubjectResponse.Message));
            }
            return new OkObjectResult(new Response<ListSubjectResponse>(listSubjectResponse));
        }


        [HttpPut]
        [Authorize()]
        [Route("editsubject")]
        public ActionResult<Response<ListSubjectResponse>> EditSubject([FromBody] SubjectModel subjectModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            ListSubjectResponse listSubjectResponse = subjectService.EditSubject(subjectModel);
            if (listSubjectResponse.Success == false)
            {
                return BadRequest(new Response<string>(listSubjectResponse.Message));
            }
            return new OkObjectResult(new Response<ListSubjectResponse>(listSubjectResponse));
        }

    }
}
