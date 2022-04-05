using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
   public interface ICourseService
    {
        string createCourse(Course course);
        string deleteCourse(int id);
        string updateCourse(Course course);
        List<Course> getCourse();
        List<Course> getCourseBasedCategory(int id);
        List<Course> getCourseById(int id);
        List<Course> getCourseByTeacherId(int TeacherId);




    }
}
