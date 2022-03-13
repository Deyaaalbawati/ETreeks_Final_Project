using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
    public interface IJWTService
    {
        string Auth(Account account);
    }
}
