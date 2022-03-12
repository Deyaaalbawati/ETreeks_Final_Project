using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
   public interface IMessageService
    {
        string createMessage(Message message);
        string deleteMessage(int id);
        string updateMessage(Message message);
        List<Message> getMessage();

    }
}
