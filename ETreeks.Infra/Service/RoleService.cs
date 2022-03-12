using ETreeks.Core.Repository;
using ETreeks.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace ETreeks.Infra.Service
{
    public class RoleService : IRoleService
    {

        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository iroleRepository)
        {

            _roleRepository = iroleRepository;
        }

        public string createRole(Role role)
        {
            return _roleRepository.createRole(role);
        }

        public string deleteRole(int id)
        {
            return _roleRepository.deleteRole(id);

        }

        public List<Role> getRole()
        {
            return _roleRepository.getRole();
        }

        public string updateRole(Role role)
        {
            return _roleRepository.updateRole(role);
        }
    }
}
