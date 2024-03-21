using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public enum RoleName
    {
        ClinicDirector,
        SurgeryDirector,
        OrthodonticsDirector,
        DoctorSurgical,
        Orthodontist,
        BasicDoctor,
        AssistantPhysician,
        Stazer,
        ManagerEquipment_
    }
    public class Role
    {
        public int Id { get; set; }
        public RoleName Name { get; set; }
        public bool IsAdministrative { get; set; }
        public List<RoleEmployee> Employees { get; set; }

    }
}
