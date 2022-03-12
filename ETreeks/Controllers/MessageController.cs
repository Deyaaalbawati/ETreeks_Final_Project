using ETreeks.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace ETreeks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService imessageService)
        {
            _messageService = imessageService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateMessage")]
        public string createMessage([FromBody] Message message)
        {
            return _messageService.createMessage(message);
        }

        [HttpDelete]
        [Route("DeleteMessage/{id}")]
        public string deleteMessage(int id)
        {
            return _messageService.deleteMessage(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Message>), StatusCodes.Status200OK)]
        [Route("GetMessage")]
        public List<Message> getMessage()
        {
            return _messageService.getMessage();
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateMessage")]
        public string updateMessage([FromBody] Message message)
        {
            return _messageService.updateMessage(message);
        }

    }


}

