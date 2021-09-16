using System;
using System.Collections.Generic;
using FrontEnd.Models;

namespace FrontEnd.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            loadEmployee();
            return base.OnInitializedAsync();
        }

        public void loadEmployee(){
            Employee e1 = new Employee{
                EmployeeId = 1,
                FirstName = "Henrikus",
                LastName = "Karel",
                Email = "henrikus@gmail.com",
                Birth = new DateTime(2000, 12, 20),
                Gender = Gender.Male,
                Department = new Department{DapartmentId=1,DepartmentName="IT"}
            };
            Employee e2 = new Employee{
                EmployeeId = 2,
                FirstName = "Dea",
                LastName = "Trikartika",
                Email = "dea@gmail.com",
                Birth = new DateTime(2000, 10, 28),
                Gender = Gender.Female,
                Department = new Department{DapartmentId=1,DepartmentName="IT"}
            };
            Employee e3 = new Employee{
                EmployeeId = 3,
                FirstName = "Susiana",
                LastName = "Sunjaya",
                Email = "susi@gmail.com",
                Birth = new DateTime(2000, 06, 12),
                Gender = Gender.Female,
                Department = new Department{DapartmentId=1,DepartmentName="IT"}
            };

            Employees = new List<Employee>{e1, e2, e3};
        }

    }    
}