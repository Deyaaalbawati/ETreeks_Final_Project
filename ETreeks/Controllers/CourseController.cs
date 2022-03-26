using ETreeks.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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



        [HttpGet("GetCourseBasedCategory/{id}")]
        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
        [Route("GetCourseBasedCategory")]
        public List<Course> getCourseBasedCategory(int id)
        {
            return _courseService.getCourseBasedCategory(id);
        }





        [HttpGet]
        [ProducesResponseType(typeof(List<Course>), StatusCodes.Status200OK)]
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

        [HttpPost]
        [Route("UploadImage")]
        public Course UploadImage()
        {
            try
            {
                //manar
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = Path.Combine("Image", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                Course course = new Course();
                course.Courseimage = fileName;
                return course;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost, DisableRequestSizeLimit]
        [Route("UploadBook")]
        public Course UploadBook()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = Path.Combine("StaticFiles", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Course course = new Course();
                course.Coursebook = fileName;
                return course;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost, DisableRequestSizeLimit]
        [Route("UploadHomeWork")]
        public Course UploadHomeWork()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = Path.Combine("StaticFiles", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Course course = new Course();
                course.Coursehomework = fileName;
                return course;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        [HttpPost, DisableRequestSizeLimit]
        [Route("UploadVideo")]
        public Course UploadVideo()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = Path.Combine("StaticFiles", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Course course = new Course();
                course.Coursevideo = fileName;
                return course;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }

}

