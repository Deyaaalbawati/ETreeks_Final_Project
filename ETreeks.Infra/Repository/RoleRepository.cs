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
    public class RoleRepository : IRoleRepository
    {

        private readonly IDbContext _context;
        public RoleRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        public string createRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("RoleIdPac", role.Roleid, dbType: System.Data.DbType.Decimal);
            p.Add("RoleNamePac", role.Rolename, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("RolePackage.createRole", p, commandType: CommandType.StoredProcedure);

            return "createRole Successed";
        }

        public string deleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("RoleIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("RolePackage.deleteRole", p, commandType: CommandType.StoredProcedure);
            return "deleteRole Successed";
        }

        public List<Role> getRole()
        {
            IEnumerable<Role> result = _context.connection.Query<Role>("RolePackage.getRole", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("RoleIdPac", role.Roleid, dbType: System.Data.DbType.Decimal);
            p.Add("RoleNamePac", role.Rolename, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("RolePackage.updateRole", p, commandType: CommandType.StoredProcedure);

            return "updateRole Successed";
        }

  
    }
}
