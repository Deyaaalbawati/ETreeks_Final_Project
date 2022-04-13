using ETreeks.Core.Data;
using ETreeks.Core.Service;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using WebApplication1.Models;

namespace ETreeks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : Controller
    {
        private readonly IJWTService iJWTService;
        public JWTController(IJWTService _iJWTService)
        {
            iJWTService = _iJWTService;
        }
        [HttpPost]
        [Route("auth")]
        public IActionResult Auth([FromBody] Account account)
        {
            var token = iJWTService.Auth(account);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }

        [HttpPost]
        [Route("SendEmail")]
        public string SendEmail([FromBody] Email email)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress mailFrom = new MailboxAddress("Etreeks", email.EmailFrom); //email from
            message.From.Add(mailFrom);
            
            MailboxAddress mailTo = new MailboxAddress("Teacher", email.EmailTo); //email from
            message.To.Add(mailTo);
            //subject
            message.Subject = "About Status Order";
            //body
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h4>Dear Teacher</h4>" +
                "Regards" +
                "Your Order is" +
                "<p style=\"color:blue\">"+email.textMsg+"</p>";
            message.Body = bodyBuilder.ToMessageBody();

            bodyBuilder.HtmlBody = email.textMsg;

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(email.EmailFrom, email.Password);
                client.Send(message);
                client.Disconnect(true);
            }

            return "SendEmail";
        }

        [HttpPost]
        [Route("SendEmailContact")]

        public string SendEmailContact([FromBody] Email email)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress mailFrom = new MailboxAddress("Etreeks", email.EmailFrom); //email from
            message.From.Add(mailFrom);

            MailboxAddress mailTo = new MailboxAddress("Teacher", email.EmailTo); //email from
            message.To.Add(mailTo);
            //subject
            message.Subject = "Etreeks Contact";
            //body
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h4>Hello</h4>" +
                "Regards" +
                "<p style=\"color:blue\">" + email.textMsg + "</p>";
            message.Body = bodyBuilder.ToMessageBody();


            bodyBuilder.HtmlBody = email.textMsg;

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(email.EmailFrom, email.Password);
                client.Send(message);
                client.Disconnect(true);
            }

            return "SendEmail";
        }
    }
}
