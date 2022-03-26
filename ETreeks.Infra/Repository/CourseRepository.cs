using Dapper;
using ETreeks.Core.Common;
using ETreeks.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IDbContext _context;
        public CourseRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        public string createCourse(Course course)
        {
            var p = new DynamicParameters();
            p.Add("AcoountIdPac", course.Acoountid, dbType: System.Data.DbType.Decimal);
            p.Add("CategoryIdPac", course.Categoryid, dbType: System.Data.DbType.Decimal);

            p.Add("CourseNamePac", course.Coursename, dbType: System.Data.DbType.String);
            p.Add("CourseDescriptionPac", course.Coursedescription, dbType: System.Data.DbType.String);
            p.Add("CourseImagePac", course.Courseimage, dbType: System.Data.DbType.String);
            p.Add("CourseRatePac", course.Courserate, dbType: System.Data.DbType.String);
            p.Add("CourseBookPac", course.Coursebook, dbType: System.Data.DbType.String);
            p.Add("CourseHomeWorkPac", course.Coursehomework, dbType: System.Data.DbType.String);
            p.Add("CourseVideoPac", course.Coursevideo, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("CoursePackage.createCourse", p, commandType: CommandType.StoredProcedure);

            return "createCourse Successed";
        }

        public string deleteCourse(int id)
        {
            var p = new DynamicParameters();
            p.Add("CourseIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("CoursePackage.deleteCourse", p, commandType: CommandType.StoredProcedure);
            return "deleteCourse Successed";
        }

        public List<Course> getCourse()
        {
            IEnumerable<Course> result = _context.connection.Query<Course>("CoursePackage.getCourse", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Course> getCourseBasedCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("CourseCategoryIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.Query<Course>("CoursePackage.getCourseBasedCategory", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateCourse(Course course)
        {
            var p = new DynamicParameters();
            p.Add("CourseIdPac", course.Courseid, dbType: System.Data.DbType.Decimal);
            p.Add("AcoountIdPac", course.Acoountid, dbType: System.Data.DbType.Decimal);
            p.Add("CategoryIdPac", course.Categoryid, dbType: System.Data.DbType.Decimal);

            p.Add("CourseNamePac", course.Coursename, dbType: System.Data.DbType.String);
            p.Add("CourseDescriptionPac", course.Coursedescription, dbType: System.Data.DbType.String);
            p.Add("CourseImagePac", course.Courseimage, dbType: System.Data.DbType.String);
            p.Add("CourseRatePac", course.Courserate, dbType: System.Data.DbType.String);
            p.Add("CourseBookPac", course.Coursebook, dbType: System.Data.DbType.String);
            p.Add("CourseHomeWorkPac", course.Coursehomework, dbType: System.Data.DbType.String);
            p.Add("CourseVideoPac", course.Coursevideo, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("CoursePackage.updateCourse", p, commandType: CommandType.StoredProcedure);

            return "updateCourse Successed";
        }
    }
}
