using ETreeks.Core.Common;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace ETreeks.Infra.Common
{
    public class DbContext :IDbContext
    {
        private DbConnection _connection;
        private readonly IConfiguration _iconfiguration;

        public DbContext(IConfiguration iconfiguration)
        {
            this._iconfiguration = iconfiguration;
        }

        public DbConnection connection
        { get
            {
                if (_connection == null)
                {
                    _connection = new OracleConnection(_iconfiguration[("ConnectionStrings:DBConnectionString")]);
                    _connection.Open();
                }

                else if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }


    }
}
