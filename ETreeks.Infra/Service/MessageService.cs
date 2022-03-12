using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class MessageService : IMessageService
    {

        private readonly IMessageRepository _messageRepository;
        public MessageService(IMessageRepository imessageRepository)
        {
            _messageRepository = imessageRepository;
        }

        public string createMessage(Message message)
        {
            return _messageRepository.createMessage(message); 
        }

        public string deleteMessage(int id)
        {
            return _messageRepository.deleteMessage(id);
        }

        public List<Message> getMessage()
        {
            return _messageRepository.getMessage();
        }

        public string updateMessage(Message message)
        {
            return _messageRepository.updateMessage(message);
        }
    }
}
