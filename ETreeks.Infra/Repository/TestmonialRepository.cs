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
    public class TestmonialRepository : ITestmonialRepository
    {

        private readonly IDbContext _context;
        public TestmonialRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }


        public string createTestmonial(Testmonial testmonial)
        {
            var p = new DynamicParameters();

            p.Add("AcoountIdPac", testmonial.Acoountid, dbType: System.Data.DbType.Decimal);
            p.Add("TestmonialCommentPac", testmonial.Testmonialcomment, dbType: System.Data.DbType.String);
            p.Add("RatePac", testmonial.Testmonialstatus, dbType: System.Data.DbType.Decimal);
            p.Add("TestmonialStatusPac", testmonial.Testmonialstatus, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("TestmonialPackage.createTestmonial", p, commandType: CommandType.StoredProcedure);

            return "createTestmonial Successed";
        }

        public string deleteTestmonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("TestmonialIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("TestmonialPackage.deleteTestmonial", p, commandType: CommandType.StoredProcedure);
            return "deleteTestmonial Successed";
        }

        public List<Testmonial> getTestmonial()
        {
            IEnumerable<Testmonial> result = _context.connection.Query<Testmonial>("TestmonialPackage.getTestmonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateTestmonial(Testmonial testmonial)
        {
            var p = new DynamicParameters();

            p.Add("TestmonialIdPac", testmonial.Testmonialid, dbType: System.Data.DbType.Decimal);
            p.Add("AcoountIdPac", testmonial.Acoountid, dbType: System.Data.DbType.Decimal);
            p.Add("TestmonialCommentPac", testmonial.Testmonialcomment, dbType: System.Data.DbType.String);
            p.Add("RatePac", testmonial.Testmonialstatus, dbType: System.Data.DbType.Decimal);
            p.Add("TestmonialStatusPac", testmonial.Testmonialstatus, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("TestmonialPackage.updateTestmonial", p, commandType: CommandType.StoredProcedure);

            return "updateTestmonial Successed";
        }
    }
}
