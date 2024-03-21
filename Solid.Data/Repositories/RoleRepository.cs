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
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext _context;
        public RoleRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Role> AddRoleAsync(Role role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }

        public async Task DeleteRoleAsync(int id)
        {
            var role=GetRoleById(id);
            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.Find(id);
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public Role UpdateRole(int id, Role role)
        {
            var existRole = GetRoleById(id);
            if (existRole != null)
            {
                existRole.IsAdministrative = role.IsAdministrative;
               _context.SaveChanges();
            }
            return existRole;
        }
    }
}
