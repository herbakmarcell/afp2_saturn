using ASP_Core.Database.Models;
using ASP_Core.Models;
using ASP_Core.Models.Responses;
using ASP_Core.Services.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly AuthIService authService;
        private readonly ICommonService commonService;
        private readonly IMessageService messageService;

        public MessageController(AuthIService authService, ICommonService commonService, IMessageService messageService)
        {
            this.authService = authService;
            this.commonService = commonService;
            this.messageService = messageService;
        }

        [HttpGet]
        [Authorize()]
        [Route("received")]
        public ActionResult<Response<List<ReceivedMessageResponse>>> GetReceivedMessages(string? saturnCode, string? sender)
        {
            saturnCode ??= commonService.TokenWithSaturn(User.Claims);
            sender ??= null;
            if (!commonService.TokenHasRole(User.Claims,"Admin") && saturnCode != commonService.TokenWithSaturn(User.Claims)) return BadRequest(new Response<string>("Insufficent permission to watch others mailbox."));
            List<ReceivedMessageResponse> receivedMessageResponses = messageService.GetReceivedMessages(saturnCode, sender);
            if (receivedMessageResponses == null) return BadRequest(new Response<string>("No existing user with messages."));
            return new OkObjectResult(new Response<List<ReceivedMessageResponse>>(receivedMessageResponses));
        }
    }
}
