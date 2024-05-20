using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Responses.DELETE;
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
        private readonly ISubjectService subjectService;
        private readonly ICommonService commonService;
        public SubjectController(ISubjectService subjectService, ICommonService commonService)
        {
            this.subjectService = subjectService;
            this.commonService = commonService;
        }

        [HttpGet]
        [Authorize()]
        [Route("listsubjects")]
        public ActionResult<Response<List<SubjectResponse>>> ListSubjects()
        {
            List<SubjectResponse>? subjects = subjectService.ListSubjects();
            if (subjects == null)
            {
                return BadRequest(new Response<string>(""));
            }
            return new OkObjectResult(new Response<List<SubjectResponse>>(subjects));
        }

        [HttpPost]
        [Authorize()]
        [Route("addnewsubject")]
        public ActionResult<Response<SubjectResponse>> AddnewSubject([FromBody] SubjectModel subject)
        {
            SubjectResponse? addedSubject = subjectService.AddNewSubject(subject);
            if (addedSubject == null)
            {
                return BadRequest(new Response<string>("Tantárgy hozzáadása nem lehetséges!"));
            }
            return new OkObjectResult(new Response<SubjectResponse>(addedSubject));
        }


        [HttpDelete]
        [Authorize()]
        [Route("deletesubject")]
        public ActionResult<Response<DeleteSubjectResponse>> DeleteSubject(string subjectCode)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Hiányzó jogosultságok!"));
            }
            DeleteSubjectResponse? deleteSubject = subjectService.DeleteSubject(subjectCode);
            if (deleteSubject == null)
            {
                return BadRequest(new Response<string>("Tárgy törlése sikertelen!"));
            }
            return new OkObjectResult(new Response<DeleteSubjectResponse>(deleteSubject));
        }


        [HttpPut]
        [Authorize()]
        [Route("editsubject")]
        public ActionResult<Response<SubjectResponse>> EditSubject([FromBody] SubjectModel subjectModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            SubjectResponse? editSubject = subjectService.EditSubject(subjectModel);
            if (editSubject == null)
            {
                return BadRequest(new Response<string>("Hiba a tárgy módosítása közben!"));
            }
            return new OkObjectResult(new Response<SubjectResponse>(editSubject));
        }

    }
}
