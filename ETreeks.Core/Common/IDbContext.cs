using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace ETreeks.Core.Common
{
   public interface IDbContext
    {
        public DbConnection connection { get; }
    }
}
