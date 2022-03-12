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

    public class ManagepageController : Controller
    {
        private readonly IManagepageService _managepageService;
        public ManagepageController(IManagepageService imanagepageService)
        {
            _managepageService = imanagepageService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateManagepage")]
        public string createManagepage([FromBody] Managepage managepage)
        {
            return _managepageService.createManagepage(managepage);
        }

        [HttpDelete]
        [Route("DeleteManagepage/{id}")]
        public string deleteManagepage(int id)
        {
            return _managepageService.deleteManagepage(id);
        }


        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateManagepage")]
        public string updateManagepage([FromBody] Managepage managepage)
        {
            return _managepageService.updateManagepage(managepage);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Managepage>), StatusCodes.Status200OK)]
        [Route("GetManagepage")]
        public List<Managepage> getManagepage()
        {
            return _managepageService.getManagepage();
        }

    }
}
