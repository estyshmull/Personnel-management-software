using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public async Task<Role> AddRoleAsync(Role role)
        {
           return await roleRepository.AddRoleAsync(role);
        }

        public async Task DeleteRoleAsync(int id)
        {
            await roleRepository.DeleteRoleAsync(id);
        }

        public Role GetRoleById(int id)
        {
           return roleRepository.GetRoleById(id);
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            return await roleRepository.GetRolesAsync();
        }

        public Role UpdateRole(int id, Role role)
        {
            return roleRepository.UpdateRole(id, role);
        }
    }
}
