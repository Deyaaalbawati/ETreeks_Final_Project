using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class LocationService : ILocationService
    {

        private readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository ilocationRepository)
        {
            this._locationRepository = ilocationRepository;
        }

        public string createLocation(Location location)
        {
            return _locationRepository.createLocation(location);
        }

        public string deleteLocation(int id)
        {
            return _locationRepository.deleteLocation(id);
        }

        public List<Location> getLocation()
        {
            return _locationRepository.getLocation();
        }

        public string updateLocation(Location location)
        {
            return _locationRepository.updateLocation(location);
        }
    }
}
