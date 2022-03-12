using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
  public interface IMessageRepository
    {
        string createMessage(Message message);
        string deleteMessage(int id);
        string updateMessage(Message message);
        List<Message> getMessage();
    }
}
