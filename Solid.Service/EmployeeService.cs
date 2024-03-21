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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository employee)
        {
            this.employeeRepository = employee;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await employeeRepository.AddEmployeeAsync(employee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await employeeRepository.DeleteEmployeeAsync(id);
        }

        public Employee GetEmployeeById(int id)
        {
            return employeeRepository.GetEmployeeById(id);
        }
        public Task<IEnumerable<Employee>> GetEmplyeesAsync()
        {
            return employeeRepository.GetEmplyeesAsync();
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            return employeeRepository.UpdateEmployee(id,employee);
        }
    }
}
