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

    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService iroleService)
        {
            _roleService = iroleService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateRole")]
        public string createRole([FromBody] Role role) 
        {
            return _roleService.createRole(role); 
        }

        [HttpDelete]
        [Route("DeleteRole/{id}")]
        public string deleteRole(int id)
        {
            return _roleService.deleteRole(id);
        }

        
        [HttpGet]
        [ProducesResponseType(typeof(List<Role>), StatusCodes.Status200OK)]
        [Route("GetRole")]
        public List<Role> getRole()
        {
            return _roleService.getRole();
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateRole")]
        public string updateRole([FromBody] Role role)
        {
            return _roleService.updateRole(role);
        }

    }
}
