﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmplyeesAsync();
        Employee GetEmployeeById(int id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Employee UpdateEmployee(int id, Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}
