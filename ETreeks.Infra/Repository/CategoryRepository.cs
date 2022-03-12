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
    public class CategoryRepository : ICategoryRepository
    {

        private readonly IDbContext _context;
        public CategoryRepository(IDbContext idbcontext)
        {
            this._context = idbcontext;
        }

        public string createCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("CategoryNamePac", category.Categoryname, dbType: System.Data.DbType.String);

            p.Add("CategoryDescriptionPac", category.Categorydescription, dbType: System.Data.DbType.String);
            p.Add("CategoryImagePac", category.Categoryimage, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("CategoryPackage.createCategory", p, commandType: CommandType.StoredProcedure);

            return "createCategory Successed";
        }

        public string deleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("CategoryIdPac", id, dbType: System.Data.DbType.Decimal);
            var result = _context.connection.ExecuteAsync("CategoryPackage.deleteCategory", p, commandType: CommandType.StoredProcedure);
            return "deleteCategory Successed";
        }

        public List<Category> getCategory()
        {
            IEnumerable<Category> result = _context.connection.Query<Category>("CategoryPackage.getCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public string updateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("CategoryIdPac", category.Categoryid, dbType: System.Data.DbType.Decimal);
            p.Add("CategoryNamePac", category.Categoryname, dbType: System.Data.DbType.String);
            p.Add("CategoryDescriptionPac", category.Categorydescription, dbType: System.Data.DbType.String);
            p.Add("CategoryImagePac", category.Categoryimage, dbType: System.Data.DbType.String);

            var result = _context.connection.ExecuteAsync("CategoryPackage.updateCategory", p, commandType: CommandType.StoredProcedure);

            return "updateCategory Successed";
        }
    }
}
