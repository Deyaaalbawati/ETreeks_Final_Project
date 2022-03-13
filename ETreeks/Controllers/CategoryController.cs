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

    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService icategoryService)
        {
            this._categoryService = icategoryService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [Route("CreateCategory")]
        public string createCategory([FromBody] Category category)
        {
            return _categoryService.createCategory(category);
        }

        [HttpDelete]
        [Route("DeleteCategory/{id}")]
        public string deleteCategory(int id)
        {
            return _categoryService.deleteCategory(id);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [Route("GetCategory")]
        public List<Category> getCategory()
        {
            return _categoryService.getCategory();
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<string>), StatusCodes.Status400BadRequest)]
        [Route("UpdateCategory")]
        public string updateCategory([FromBody] Category category)
        {
            return _categoryService.updateCategory(category);
        }

        [HttpPost]
        [Route("UploadImage")]
        public Category UploadImage()
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

                Category category = new Category();
                category.Categoryimage = fileName;
                return category;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
