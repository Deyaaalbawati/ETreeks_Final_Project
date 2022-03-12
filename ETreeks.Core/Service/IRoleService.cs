using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
  public  interface IRoleService
    {
        string createRole(Role role);
        string deleteRole(int id);
        string updateRole(Role role);
        List<Role> getRole();
    }
}
