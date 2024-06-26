﻿using ASP_Core.Database;
using ASP_Core.Database.Models;
using ASP_Core.Models.Auth;
using ASP_Core.Models.Message;
using ASP_Core.Models.Responses;
using ASP_Core.Models.Responses.DELETE;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Models.Responses.POST;
using System.Security.Claims;

namespace ASP_Core.Services.Auth
{
    public interface IMessageService
    {
        public List<ReceivedMessageResponse> GetReceivedMessages(string? saturnCode, string? sender);
        public List<SentMessageResponse> GetSentMessages(string sender);
        public SendMessageResponse? SendMessage(SendMessageModelRequest messageModel);
        public DeleteMessageResponse? DeleteMessage(DeleteMessageModelRequest deleteModel);
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
            List<MessageModel> contextReceivedMessages = saturnContext.GetReceivedMessages(saturnCode, sender);
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

        public List<SentMessageResponse> GetSentMessages(string sender)
        {
            List<MessageModel> contextSentMessages = saturnContext.GetSentMessages(sender);
            if (contextSentMessages == null) return null;

            List<SentMessageResponse> sentMessages = contextSentMessages.Select(message => new SentMessageResponse
            {
                Id = message.Id,
                Subject = message.Subject,
                Content = message.Content,
                Sender = message.Sender.SaturnCode,
                Receivers = message.Receivers.Select(user => user.SaturnCode).ToList()
            }).ToList();

            return sentMessages;
        }

        public SendMessageResponse? SendMessage(SendMessageModelRequest messageModel)
        {
            if (messageModel.Receivers.Count == 0)
                return null;
            User? senderUser = saturnContext.UserWithSaturnCode(messageModel.Sender);
            if (senderUser == null)
                return null;

            List<User?> receivers = messageModel.Receivers
                .Select(saturnContext.UserWithSaturnCode)
                .Where(receiverUser => receiverUser != null)
                .ToList();
            if (receivers == null || receivers.Count == 0)
                return null;

            MessageModel message = new MessageModel
            {
                Sender = senderUser,
                Subject = messageModel.Subject,
                Content = messageModel.Content,
                Receivers = receivers
            };

            SendMessageResponse messageResponse = saturnContext.SendMessage(message);
            return messageResponse;
        }

        // implement deletemessage
        public DeleteMessageResponse? DeleteMessage(DeleteMessageModelRequest deleteModel)
        {
            User? user = saturnContext.UserWithSaturnCode(deleteModel.SaturnCode);
            if (user == null)
                return null;

            DeleteMessageResponse? message = saturnContext.DeleteMessage(deleteModel);
            if (message == null)
                return null;

            return new DeleteMessageResponse
            {
                SaturnCode = deleteModel.SaturnCode,
                MessageId = message.MessageId
            };
        }
    }
}
