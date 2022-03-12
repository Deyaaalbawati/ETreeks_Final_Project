using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
   public interface IManagepageRepository
    {
        string createManagepage(Managepage managepage);
        string deleteManagepage(int id);
        string updateManagepage(Managepage managepage);
        List<Managepage> getManagepage ();
    }
}
