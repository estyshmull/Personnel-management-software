using Solid.Core.Entities;
using System.Data;

namespace MyPractikum.Models
{
    public class EmployeePostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateStartWork { get; set; }
        public Gender Gender { get; set; }
        public bool Status { get; set; } 
    }
}
