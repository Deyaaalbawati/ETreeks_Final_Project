using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
   public interface ICategoryService
    {
        string createCategory(Category category);
        string deleteCategory(int id);
        string updateCategory(Category category);
        List<Category> getCategory();
        int getNumberCategory();
    }
}
