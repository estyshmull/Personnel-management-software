using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class RoleEmployeeRepository:IRoleEmployeeRepository
    {
        private readonly DataContext _context;
        public RoleEmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<RoleEmployee> AddRoleEmpAsync(RoleEmployee role_emp)
        {
            _context.RoleEmployees.Add(role_emp);
            await _context.SaveChangesAsync();
            return role_emp;
        }

        public async Task DeleteRoleEmpAsync(int id)
        {
            var rol_emp=GetRoleEmpById(id);
            _context.RoleEmployees.Remove(rol_emp);
            await _context.SaveChangesAsync();
        }

        public RoleEmployee GetRoleEmpById(int id)
        {
            return _context.RoleEmployees.Find(id);
        }

        public async Task<IEnumerable<RoleEmployee>> GetRolesEmpAsync()
        {
            return await _context.RoleEmployees.ToListAsync();
        }

        public RoleEmployee UpdateRoleEmployee(int id, RoleEmployee role_emp)
        {
            var existRoleEmp = GetRoleEmpById(id);
            if (existRoleEmp != null)
            {
                existRoleEmp.Status = role_emp.Status;
                _context.SaveChanges();
            }
            return existRoleEmp;
        }
    }
}
