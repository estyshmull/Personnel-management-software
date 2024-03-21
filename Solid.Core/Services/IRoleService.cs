﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetRolesAsync();
        Role GetRoleById(int id);
        Task<Role>AddRoleAsync(Role role);
        Role UpdateRole(int id, Role role); 
        Task DeleteRoleAsync(int id);
    }
}
