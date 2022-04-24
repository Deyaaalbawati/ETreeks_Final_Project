using ETreeks.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
    public interface IJWTRepoistory
    {
        LoginDTO Auth(Account account);
        LoginDTO AuthStudent(Account account);

    }
}
