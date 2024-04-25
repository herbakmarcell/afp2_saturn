using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Responses;
using System.Security.Claims;

namespace ASP_Core.Services.Auth
{
    public interface IMessageService
    {
        public List<ReceivedMessageResponse> GetReceivedMessages(string? saturnCode, string? sender);
    }

    public class MessageService : IMessageService
    {
        private readonly SaturnContext saturnContext;
        public MessageService(SaturnContext saturnContext)
        {
            this.saturnContext = saturnContext;
        }


        public List<ReceivedMessageResponse> GetReceivedMessages(string saturnCode, string? sender)
        {
            List<MessageModel> contextReceivedMessages = saturnContext.GetReceivedMessage(saturnCode, sender);
            if (contextReceivedMessages == null) return null;

            List<ReceivedMessageResponse> receivedMessages = contextReceivedMessages.Select(message => new ReceivedMessageResponse
            {
                Id = message.Id,
                Subject = message.Subject,
                Content = message.Content,
                Sender = message.Sender.SaturnCode,
                Receivers = message.Receivers.Select(user => user.SaturnCode).ToList()
            }).ToList();

            return receivedMessages;
        }
    }
}
