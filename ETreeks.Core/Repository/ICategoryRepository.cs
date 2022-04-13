using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
   public interface ICategoryRepository
    {
        string createCategory(Category category);
        string deleteCategory(int id);
        string updateCategory(Category category);
        List<Category> getCategory ();
        int getNumberCategory();
    }
}
