using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
   public interface ICourseRepository
    {
        string createCourse(Course course);
        string deleteCourse(int id);
        string updateCourse(Course course);
        List<Course> getCourse();

        List<Course> getCourseBasedCategory(int id);
    }
}
