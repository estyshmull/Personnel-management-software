using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Role,RoleDTO>().ReverseMap();
            CreateMap<RoleEmployee,RoleEmpDTO>().ReverseMap();
        }
    }
}
