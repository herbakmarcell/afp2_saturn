using ASP_Core.Models;
using ASP_Core.Models.Class;
using ASP_Core.Models.Exam;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Services.Auth;
using ASP_Core.Services.Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Core.Controllers
{
    public class ClassController : ControllerBase
    {
        private readonly IClassService ClassService;
        private readonly ICommonService commonService;
        public ClassController(IClassService classService, ICommonService commonService)
        {
            this.ClassService = classService;
            this.commonService = commonService;
        }
        [HttpPost]
        [Authorize()]
        [Route("addclass")]
        public ActionResult<Response<ClassResponse?>> AddClass([FromBody] AddClassRequest addClassRequest)
        {
            ClassResponse? classResponse = ClassService.AddClass(addClassRequest);
            if (!commonService.TokenHasRole(User.Claims, "Admin") && !commonService.TokenHasRole(User.Claims, "Teacher"))
            {
                return Unauthorized(new Response<string>("Hiányzó jogosultságok!"));
            }
            if (classResponse == null)
            {
                return BadRequest(new Response<string>("Hiba a létrehozás közben!"));
            }
            return new OkObjectResult(new Response<ClassResponse>(classResponse));
        }
        [HttpDelete]
        [Authorize()]
        [Route("deleteclass")]
        public ActionResult<Response<ClassResponse>> DeleteClass([FromQuery] int classId)
        {
            ClassResponse? classResponse = ClassService.DeleteClass(classId);
            if (!commonService.TokenHasRole(User.Claims, "Admin") && !commonService.TokenHasRole(User.Claims, "Teacher"))
            {
                return Unauthorized(new Response<string>("Hiányzó jogosultságok!"));
            }
            if (classResponse == null)
            {
                return BadRequest(new Response<string>("Sikertelen törlés!"));
            }
            return new OkObjectResult(new Response<ClassResponse>(classResponse));
        }

        [HttpPut]
        [Authorize()]
        [Route("editclass")]
        public ActionResult<Response<ClassResponse>> EditClass([FromBody] EditClassRequest? editClassModel)
        {
            if (!commonService.TokenHasRole(User.Claims, "Admin"))
            {
                return Unauthorized(new Response<string>("Missing Admin permissions"));
            }
            ClassResponse? response = ClassService.EditClass(editClassModel);
            if (response == null)
            {
                return BadRequest(new Response<string>("Sikertelen módosítás!"));
            }
            return new OkObjectResult(new Response<ClassResponse>(response));
        }


        [HttpGet]
        [Authorize()]
        [Route("searchclassesbyid")]
        public ActionResult<Response<ClassResponse>> SearchClassesById(int? id)
        {
            ClassResponse? searchedClass = ClassService.SearchClassesById(id);
            if (searchedClass == null)
            {
                return BadRequest(new Response<string>("Nincs ilyen ID-val rendelkező óra!"));
            }
            return new OkObjectResult(new Response<ClassResponse>(searchedClass));
        }

        [HttpGet]
        [Authorize()]
        [Route("searchclassbytime")]
        public ActionResult<Response<List<ClassResponse?>>> SearchClassesByTime(bool byStart, bool byMin, DateTime time)
        {
            List<ClassResponse?> searchedClass = ClassService.SearchClassesByTime(byStart, byMin, time);
            if (searchedClass == null)
            {
                return BadRequest(new Response<string>("Nincs ilyen időpontban óra!"));
            }
            return new OkObjectResult(new Response<List<ClassResponse?>>(searchedClass));
        }

    }
}
