using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class ManagepageService : IManagepageService
    {

        private readonly IManagepageRepository _managepageRepository;
        public ManagepageService(IManagepageRepository imanagepageRepository)
        {
            _managepageRepository = imanagepageRepository;
        }


        public string createManagepage(Managepage managepage)
        {
            return _managepageRepository.createManagepage(managepage);
        }


        public string deleteManagepage(int id)
        {
            return _managepageRepository.deleteManagepage(id);
        }


        public List<Managepage> getManagepage()
        {
            return _managepageRepository.getManagepage();
        }


        public string updateManagepage(Managepage managepage)
        {
            return _managepageRepository.updateManagepage(managepage);
        }

    }
}
