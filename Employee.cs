using System;

namespace FrontEnd.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }
        public Department Department { get; set; }
        public Gender Gender { get; internal set; }
    }

    public enum Gender {
        Male, Female
    }
}