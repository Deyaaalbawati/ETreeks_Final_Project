using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Core.Repository
{
  public  interface ILocationRepository
    {
        string createLocation(Location location);
        string deleteLocation(int id);
        string updateLocation(Location location);
        List<Location> getLocation();
    }
}
