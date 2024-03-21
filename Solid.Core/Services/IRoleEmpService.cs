using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IRoleEmpService
    {
        Task<IEnumerable<RoleEmployee>> GetRoleEmployeesAsync();
        RoleEmployee GetRolEmpById(int id);
        Task<RoleEmployee>AddRolEmpAsync(RoleEmployee employee);
        RoleEmployee UpdateRolEmp(int id, RoleEmployee roleEmployee);
        Task DeleteRolEmpAsync(int id);
    }
}
