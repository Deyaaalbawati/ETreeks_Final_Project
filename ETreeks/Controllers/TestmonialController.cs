using ETreeks.Core.DTO;
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

    public class TestmonialController : Controller
    {
        private readonly ITestmonialService _testmonialService;
        public TestmonialController(ITestmonialService itestmonialService)
        {
            _testmonialService = itestmonialService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateTestmonial")]
        public string createTestmonial([FromBody] Testmonial testmonial)
        {
            return _testmonialService.createTestmonial(testmonial);
        }

        [HttpDelete]
        [Route("DeleteTestmonial/{id}")]
        public string deleteTestmonial(int id)
        {
            return _testmonialService.deleteTestmonial(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Testmonial>), StatusCodes.Status200OK)]
        [Route("GetTestmonial")]
        public List<Testmonial> getTestmonial()
        {
            return _testmonialService.getTestmonial();
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateTestmonial")]
        public string updateTestmonial([FromBody] Testmonial testmonial)
        {
            return _testmonialService.updateTestmonial(testmonial);
        }


        [HttpGet("GetTestmonialAccount")]
        [ProducesResponseType(typeof(List<TestmonialAccount>), StatusCodes.Status200OK)]
        [Route("GetTestmonialAccount")]
        public List<TestmonialAccount> getTestmonialAccount()
        {
            return _testmonialService.getTestmonialAccount();
        }

    }

}

