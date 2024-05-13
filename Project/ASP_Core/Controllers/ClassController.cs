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
    public class ClassController : ControllerBase
    {
        private readonly ClassIService ClassService;
        private readonly ICommonService commonService;
        public ClassController(ClassIService classService, ICommonService commonService)
        {
            this.ClassService = classService;
            this.commonService = commonService;
        }
        [HttpPost]
        [Authorize()]
        [Route("addnewclass")]
        public ActionResult<Response<StandardClassResponse>> AddnewClass([FromBody]CreateClassRequestModel createClassRequestModel)
        {
            StandardClassResponse classResponse = ClassService.AddNewClass(createClassRequestModel);
            if (classResponse.Success == false)
            {
                return BadRequest(new Response<string>(classResponse.Message));
            }
            return new OkObjectResult(new Response<StandardClassResponse>(classResponse));
        }
        [HttpDelete]
        [Authorize()]
        [Route("deleteclass")]
        public ActionResult<Response<StandardClassResponse>> DeleteClass([FromBody] int classId)
        {
            StandardClassResponse classResponse = ClassService.DeleteClass(classId);
            if (classResponse.Success == false)
            {
                return BadRequest(new Response<string>(classResponse.Message));
            }
            return new OkObjectResult(new Response<StandardClassResponse>(classResponse));
        }

        [HttpPut]
        [Authorize()]
        [Route("editclass")]
        public ActionResult<Response<StandardExamResponse>> EditClass([FromBody] EditClassModel editClassModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            StandardClassResponse StandardClassResponse = ClassService.EditClass(editClassModel);
            if (StandardClassResponse.Success == false)
            {
                return BadRequest(new Response<string>(StandardClassResponse.Message));
            }
            return new OkObjectResult(new Response<StandardClassResponse>(StandardClassResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchclassesbyid")]
        public ActionResult<Response<ListClassResponse>> SearchClassesById([FromQuery] int id)
        {
            ListClassResponse listClassesResponse = ClassService.SearchClassesById(id);
            if (listClassesResponse.Success == false)
            {
                return BadRequest(new Response<string>(listClassesResponse.Message));
            }
            return new OkObjectResult(new Response<ListClassResponse>(listClassesResponse));
        }
        [HttpGet]
        [Authorize()]
        [Route("searchclassesbystartmin")]
        public ActionResult<Response<ListClassResponse>> SearchClassesByStartmin([FromQuery] DateTime startTime)
        {
            ListClassResponse listClassesResponse = ClassService.SearchClassesByStartmin(startTime);
            if (listClassesResponse.Success == false)
            {
                return BadRequest(new Response<string>(listClassesResponse.Message));
            }
            return new OkObjectResult(new Response<ListClassResponse>(listClassesResponse));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchclassesbystartmax")]
        public ActionResult<Response<ListClassResponse>> SearchClassesByStartmax([FromQuery] DateTime startTime)
        {
            ListClassResponse listClassesResponse = ClassService.SearchClassesByStartmax(startTime);
            if (listClassesResponse.Success == false)
            {
                return BadRequest(new Response<string>(listClassesResponse.Message));
            }
            return new OkObjectResult(new Response<ListClassResponse>(listClassesResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchclassesbyendmin")]
        public ActionResult<Response<ListClassResponse>> SearchClassesByEndmin([FromQuery] DateTime Time)
        {
            ListClassResponse listClassesResponse = ClassService.SearchClassesByEndmin(Time);
            if (listClassesResponse.Success == false)
            {
                return BadRequest(new Response<string>(listClassesResponse.Message));
            }
            return new OkObjectResult(new Response<ListClassResponse>(listClassesResponse));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchclassesbyendmax")]
        public ActionResult<Response<ListClassResponse>> SearchClassesByEndmax([FromQuery] DateTime Time)
        {
            ListClassResponse listClassesResponse = ClassService.SearchClassesByEndmax(Time);
            if (listClassesResponse.Success == false)
            {
                return BadRequest(new Response<string>(listClassesResponse.Message));
            }
            return new OkObjectResult(new Response<ListClassResponse>(listClassesResponse));
        }
    }
}
