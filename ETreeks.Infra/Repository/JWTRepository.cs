using Dapper;
using ETreeks.Core.Common;
using ETreeks.Core.DTO;
using ETreeks.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Repository
{
    public class JWTRepository : IJWTRepoistory
    {
        private readonly IDbContext _context;
        public JWTRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        
        public LoginDTO Auth(Account account)
        {
            var p = new DynamicParameters();
            p.Add("@emailPac", account.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@passwordPac", account.Accountpassword, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<LoginDTO> result = _context.connection.Query<LoginDTO>("AccountLogin", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}

