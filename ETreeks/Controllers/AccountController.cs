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

    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService iaccountService)
        {
            _accountService = iaccountService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateAccount")]
        public string createAccount([FromBody] Account account)
        {
            return _accountService.createAccount(account);
        }


        [HttpDelete]
        [Route("DeleteAccount/{id}")]
        public string deleteAccount(int id)
        {
            return _accountService.deleteAccount(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Account>), StatusCodes.Status200OK)]
        [Route("GetAccount")]
        public List<Account> getAccount()
        {
            return _accountService.getAccount();
        }


        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateAccount")]
        public string updateAccount([FromBody] Account account)
        {
            return _accountService.updateAccount(account);
        }

    }
}
