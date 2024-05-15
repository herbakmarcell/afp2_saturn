using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
using ASP_Core.Services.Auth;
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
        
    }
}
