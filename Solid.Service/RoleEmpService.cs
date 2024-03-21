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
    public class RoleEmpService : IRoleEmpService
    {
        private readonly IRoleEmployeeRepository roleEmployeeRepository ;
        public RoleEmpService(IRoleEmployeeRepository roleEmployeeRepository)
        {
            this.roleEmployeeRepository = roleEmployeeRepository;
        }

        public async Task<RoleEmployee> AddRolEmpAsync(RoleEmployee employee)
        {
            return await roleEmployeeRepository.AddRoleEmpAsync(employee);
        }

        public async Task DeleteRolEmpAsync(int id)
        {
            await roleEmployeeRepository.DeleteRoleEmpAsync(id);
        }

        public async Task<IEnumerable<RoleEmployee>> GetRoleEmployeesAsync()
        {
            return await roleEmployeeRepository.GetRolesEmpAsync();
        }

        public RoleEmployee GetRolEmpById(int id)
        {
            return roleEmployeeRepository.GetRoleEmpById(id);
        }

        public RoleEmployee UpdateRolEmp(int id, RoleEmployee roleEmployee)
        {
            return roleEmployeeRepository.UpdateRoleEmployee(id, roleEmployee); 
        }
    }
}
