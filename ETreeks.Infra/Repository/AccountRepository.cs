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
    public class AccountRepository : IAccountRepository
    {
        
        private readonly IDbContext _context;
        public AccountRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        public string createAccount(Account account)
        {
            var p = new DynamicParameters();
            p.Add("RoleIdPac", account.Roleid, dbType: System.Data.DbType.Decimal);
            p.Add("FirstNamePac", account.Firstname, dbType: System.Data.DbType.String);
            p.Add("LastNamePac", account.Lastname, dbType: System.Data.DbType.String);
            p.Add("AccountPasswordPac", account.Accountpassword, dbType: System.Data.DbType.String);
            p.Add("EmailPac", account.Email, dbType: System.Data.DbType.String);
            p.Add("PhoneNumberPac", account.Phonenumber, dbType: System.Data.DbType.String);
            p.Add("GenderPac", account.Gender, dbType: System.Data.DbType.String);

            p.Add("BirthOFDatePac", account.Birthofdate, dbType: System.Data.DbType.DateTime);

            p.Add("ProfilePicturePac", account.Profilepicture, dbType: System.Data.DbType.String);
            p.Add("AccountStatusPac", account.Accountstatus, dbType: System.Data.DbType.String);
            p.Add("CertificatePac", account.Certificate, dbType: System.Data.DbType.String);
            p.Add("SpecializationPac", account.Specialization, dbType: System.Data.DbType.String);
            p.Add("WlinePac", account.Wline, dbType: System.Data.DbType.String);
            p.Add("HlinePac", account.Hline, dbType: System.Data.DbType.String);




            var result = _context.connection.ExecuteAsync("AccountPackage.createAccount", p, commandType: CommandType.StoredProcedure);

            return "createAccount Successed";
        }

        public string deleteAccount(int id)
        {
            var p = new DynamicParameters();
            p.Add("AcoountIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("AccountPackage.deleteAccount", p, commandType: CommandType.StoredProcedure);
            return "deleteAccount Successed";
        }

        public List<Account> getAccount()
        {
            IEnumerable<Account> result = _context.connection.Query<Account>("AccountPackage.getAccount", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Account> getStudent()
        {
            IEnumerable<Account> result = _context.connection.Query<Account>("AccountPackage.getStudent", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int getNumberStudent()
        {
            IEnumerable<Account> result = _context.connection.Query<Account>("AccountPackage.getStudent", commandType: CommandType.StoredProcedure);
            return result.ToList().Count();
        }

        public int getNumberTeacher()
        {
            IEnumerable<Account> result = _context.connection.Query<Account>("AccountPackage.getTeacher", commandType: CommandType.StoredProcedure);
            return result.ToList().Count();
        }

        public List<Account> getTeacher()
        {
            IEnumerable<Account> result = _context.connection.Query<Account>("AccountPackage.getTeacher", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        
        public List<Account> searchTeacher(Account account)
        {
            var p = new DynamicParameters();
            p.Add("TeacherName", account.Firstname, dbType: System.Data.DbType.String);
            var result = _context.connection.Query<Account>("AccountPackage.searchTeacher", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        //public List<WA_Course> GetByCourseName(WA_Course course)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@Cname", course.CourseName, dbType: DbType.String, direction: ParameterDirection.Input);
        //    IEnumerable<WA_Course> result = DbContext.Connection.Query<WA_Course>("WA_COURSE_PACKAGE.GetByCourseName", commandType: CommandType.StoredProcedure);
        //    return result.ToList();
        //}

        public string updateAccount(Account account)
        {
            var p = new DynamicParameters();
            p.Add("AcoountIdPac", account.Acoountid, dbType: System.Data.DbType.Decimal);
            p.Add("RoleIdPac", account.Roleid, dbType: System.Data.DbType.Decimal);
            p.Add("FirstNamePac", account.Firstname, dbType: System.Data.DbType.String);
            p.Add("LastNamePac", account.Lastname, dbType: System.Data.DbType.String);
            p.Add("AccountPasswordPac", account.Accountpassword, dbType: System.Data.DbType.String);
            p.Add("EmailPac", account.Email, dbType: System.Data.DbType.String);
            p.Add("PhoneNumberPac", account.Phonenumber, dbType: System.Data.DbType.String);
            p.Add("GenderPac", account.Gender, dbType: System.Data.DbType.String);

            p.Add("BirthOFDatePac", account.Birthofdate, dbType: System.Data.DbType.DateTime);

            p.Add("ProfilePicturePac", account.Profilepicture, dbType: System.Data.DbType.String);
            p.Add("AccountStatusPac", account.Accountstatus, dbType: System.Data.DbType.String);
            p.Add("CertificatePac", account.Certificate, dbType: System.Data.DbType.String);
            p.Add("SpecializationPac", account.Specialization, dbType: System.Data.DbType.String);
            p.Add("WlinePac", account.Wline, dbType: System.Data.DbType.String);
            p.Add("HlinePac", account.Hline, dbType: System.Data.DbType.String);


            var result = _context.connection.ExecuteAsync("AccountPackage.updateAccount", p, commandType: CommandType.StoredProcedure);

            return "updateAccount Successed";
        }

       
    }
}
