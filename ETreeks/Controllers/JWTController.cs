using ETreeks.Core.Service;
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
    public class JWTController : Controller
    {
        private readonly IJWTService iJWTService;
        public JWTController(IJWTService _iJWTService)
        {
            iJWTService = _iJWTService;
        }
        [HttpPost]
        public IActionResult Auth([FromBody]Account account)
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
    }
}
