using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IRoleEmployeeRepository
    {
        Task<IEnumerable<RoleEmployee>> GetRolesEmpAsync();
        RoleEmployee GetRoleEmpById(int id);
        Task<RoleEmployee> AddRoleEmpAsync(RoleEmployee role_emp);
        RoleEmployee UpdateRoleEmployee(int id, RoleEmployee role_emp);
        Task DeleteRoleEmpAsync(int id);
    }
}
