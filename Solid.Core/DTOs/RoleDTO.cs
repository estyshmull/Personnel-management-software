using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class RoleDTO
    {
        public RoleName Name { get; set; }
        public bool IsAdministrative { get; set; }
    }
}
