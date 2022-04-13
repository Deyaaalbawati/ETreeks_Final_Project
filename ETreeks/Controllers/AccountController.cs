using ETreeks.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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

        String ProfilePicture;
        String Certificate;

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



        [HttpGet]
        [ProducesResponseType(typeof(List<Account>), StatusCodes.Status200OK)]
        [Route("GetStudent")]
        public List<Account> getStudent()
        {
            return _accountService.getStudent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Account>), StatusCodes.Status200OK)]
        [Route("GetTeacher")]
        public List<Account> getTeacher()
        {
            return _accountService.getTeacher();
        }

        [Route("getNumberStudent")]
        public int getNumberStudent()
        {
            return _accountService.getNumberStudent();
        }

        [Route("getNumberTeacher")]
        public int getNumberTeacher()
        {
            return _accountService.getNumberTeacher();
        }


        [HttpGet("SearchTeacher/{TeacherName}")]
        [ProducesResponseType(typeof(List<Account>), StatusCodes.Status200OK)]
        [Route("SearchTeacher")]
        public List<Account> searchTeacher(string TeacherName)
        {
            return _accountService.searchTeacher(TeacherName);
        }



        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateAccount")]
        public string updateAccount([FromBody] Account account)
        {
            return _accountService.updateAccount(account);
        }


        //I Edit this code. // Deyaa // Look at the create account //
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("UploadImage")]
        public String UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = Path.Combine("Image", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }


                this.ProfilePicture = fileName;
                return this.ProfilePicture;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost, DisableRequestSizeLimit]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("UploadCertificate")]
        public String UploadCertificate()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = Path.Combine("Image", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                this.Certificate = fileName;
                return this.Certificate;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}

