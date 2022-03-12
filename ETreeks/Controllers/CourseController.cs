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

    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService icourseService)
        {
            _courseService = icourseService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateCourse")]
        public string createCourse([FromBody] Course course)
        {
            return _courseService.createCourse(course);
        }

        [HttpDelete]
        [Route("DeleteCourse/{id}")]
        public string deleteCourse(int id)
        {
            return _courseService.deleteCourse(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Role>), StatusCodes.Status200OK)]
        [Route("GetCourse")]
        public List<Course> getCourse()
        {
            return _courseService.getCourse();
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateCourse")]
        public string updateCourse([FromBody] Course course)
        {
            return _courseService.updateCourse(course);
        }

    }

}

