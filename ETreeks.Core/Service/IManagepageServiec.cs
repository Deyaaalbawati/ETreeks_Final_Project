using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
   public interface IManagepageService
    {
        string createManagepage(Managepage managepage);
        string deleteManagepage(int id);
        string updateManagepage(Managepage managepage);
        List<Managepage> getManagepage();
    }
}
