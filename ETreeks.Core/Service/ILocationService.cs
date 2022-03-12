using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Service
{
   public interface ILocationService
    {
        string createLocation(Location location);
        string deleteLocation(int id);
        string updateLocation(Location location);
        List<Location> getLocation();
    }
}
