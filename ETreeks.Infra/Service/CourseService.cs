using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository icourseRepository)
        {
            _courseRepository = icourseRepository;
        }

        public string createCourse(Course course)
        {
            return _courseRepository.createCourse(course);
        }

        public string deleteCourse(int id)
        {
            return _courseRepository.deleteCourse(id);
        }

        public List<Course> getCourse()
        {
            return _courseRepository.getCourse();

        }

        public List<Course> getCourseBasedCategory(int id)
        {
            return _courseRepository.getCourseBasedCategory(id);
        }

        public List<Course> getCourseById(int id)
        {
            return _courseRepository.getCourseById(id);
        }

        public string updateCourse(Course course)
        {
            return _courseRepository.updateCourse(course);
        }
    }
}
