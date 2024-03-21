using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class EmployeeDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public bool Status { get; set; }
    }
}
