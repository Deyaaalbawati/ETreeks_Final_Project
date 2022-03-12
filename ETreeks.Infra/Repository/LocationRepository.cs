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
    public class LocationRepository : ILocationRepository
    {

        private readonly IDbContext _context;
        public LocationRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        public string createLocation(Location location)
        {
            var p = new DynamicParameters();

            p.Add("WLinePac",location.Wline, dbType: System.Data.DbType.String);
            p.Add("HLinePac", location.Hline, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("LocationPackage.createLocation", p, commandType: CommandType.StoredProcedure);

            return "createLocation Successed";
        }

        public string deleteLocation(int id)    
        {
            var p = new DynamicParameters();
            p.Add("LocationIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("LocationPackage.deleteLocation", p, commandType: CommandType.StoredProcedure);
            return "deleteLocation Successed";
        }

        public List<Location> getLocation()
        {
            IEnumerable<Location> result = _context.connection.Query<Location>("LocationPackage.getLocation", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateLocation(Location location)
        {
            var p = new DynamicParameters();
            p.Add("LocationIdPac", location.Locationid, dbType: System.Data.DbType.Decimal);
            p.Add("WLinePac", location.Wline, dbType: System.Data.DbType.String);
            p.Add("HLinePac", location.Hline, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("LocationPackage.updateLocation", p, commandType: CommandType.StoredProcedure);

            return "updateLocation Successed";
        }
    }
}
