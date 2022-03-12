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
    public class ManagepageRepository : IManagepageRepository
    {

        private readonly IDbContext _context;
        public ManagepageRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }


        public string createManagepage(Managepage managepage)
        {
            var p = new DynamicParameters();
            p.Add("AboutUsTextPac", managepage.Aboutustext, dbType: System.Data.DbType.String);
            p.Add("AboutUsPhonePac", managepage.Aboutusphone, dbType: System.Data.DbType.String);
            p.Add("AboutUsEmailPac", managepage.Aboutusemail, dbType: System.Data.DbType.String);
            p.Add("AboutUsAddersPac", managepage.Aboutusadders, dbType: System.Data.DbType.String);
            p.Add("BackgroundPac", managepage.Background, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("ManagepagePackage.createManagepage", p, commandType: CommandType.StoredProcedure);

            return "createManagepage Successed";
        }

        public string deleteManagepage(int id)
        {
            var p = new DynamicParameters();
            p.Add("ManagepageIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("ManagepagePackage.deleteManagepage", p, commandType: CommandType.StoredProcedure);
            return "deleteManagepage Successed";
        }

        public List<Managepage> getManagepage()
        {
            IEnumerable<Managepage> result = _context.connection.Query<Managepage>("ManagepagePackage.getManagepage", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateManagepage(Managepage managepage)
        {
            var p = new DynamicParameters();
            p.Add("ManagepageIdPac", managepage.Managepageid, dbType: System.Data.DbType.Decimal);
            p.Add("AboutUsTextPac", managepage.Aboutustext, dbType: System.Data.DbType.String);
            p.Add("AboutUsPhonePac", managepage.Aboutusphone, dbType: System.Data.DbType.String);
            p.Add("AboutUsEmailPac", managepage.Aboutusemail, dbType: System.Data.DbType.String);
            p.Add("AboutUsAddersPac", managepage.Aboutusadders, dbType: System.Data.DbType.String);
            p.Add("BackgroundPac", managepage.Background, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("ManagepagePackage.updateManagepage", p, commandType: CommandType.StoredProcedure);

            return "updateManagepage Successed";
        }
    }
}
