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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context) 
        { 
             _context = context;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employee=GetEmployeeById(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Include(e => e.Roles).First(e => e.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetEmplyeesAsync()
        {
            return await _context.Employees.Include(e=>e.Roles).ToListAsync();  
        }

        public Employee UpdateEmployee(int id,Employee employee)
        {
            var existEmployee = GetEmployeeById(id);
            existEmployee.LastName=existEmployee.LastName;
            existEmployee.Status= existEmployee.Status;
            _context.SaveChanges();
            return existEmployee;
        }
    }
}
