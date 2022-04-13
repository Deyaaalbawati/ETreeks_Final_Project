using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository icategoryRepository)
        {
            _categoryRepository = icategoryRepository;
        }

        public string createCategory(Category category)
        {
            return _categoryRepository.createCategory(category);
        }

        public string deleteCategory(int id)
        {
            return _categoryRepository.deleteCategory(id);
        }

        public List<Category> getCategory()
        {
            return _categoryRepository.getCategory();
        }

        public string updateCategory(Category category)
        {
            return _categoryRepository.updateCategory(category);
        }

        public int getNumberCategory()
        {
            return _categoryRepository.getNumberCategory();
        }
    }
}
