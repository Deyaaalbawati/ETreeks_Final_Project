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
    public class LocationController : Controller
    {

        private readonly ILocationService _locationService;
        public LocationController(ILocationService ilocationService)
        {
            _locationService = ilocationService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateLocation")]
        public string createLocation([FromBody] Location location)
        {
            return _locationService.createLocation(location);
        }

        [HttpDelete]
        [Route("DeleteLocation/{id}")]
        public string deleteLocation(int id)
        {
            return _locationService.deleteLocation(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Location>), StatusCodes.Status200OK)]
        [Route("GetLocation")]
        public List<Location> getLocation()
        {
            return _locationService.getLocation();
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateLocation")]
        public string updateLocation([FromBody] Location location)
        {
            return _locationService.updateLocation(location);
        }

    }
}
