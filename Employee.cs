using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperations
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployee = new List<Employee>
            {
                new Employee
                {
                      EmployeeID = 101,
                      FirstName = "Tom",
                      LastName = "Daely",
                      Gender = "male",
                      AnnualSalary = 68000
                },
                new Employee
                {
                   EmployeeID = 102,
                      FirstName = "Jonny",
                      LastName = "Bhai",
                      Gender = "male",
                      AnnualSalary = 6900
                },
                  new Employee
                {
                   EmployeeID = 103,
                      FirstName = "Monay",
                      LastName = "Bro",
                      Gender = "male",
                      AnnualSalary = 6700
                },
                    new Employee
                {
                   EmployeeID = 104,
                      FirstName = "Roshani",
                      LastName = "MR",
                      Gender = "Female",
                      AnnualSalary = 6900
                },
                    new Employee
                {
                   EmployeeID = 105,
                      FirstName = "Mahi",
                      LastName = "Patil",
                      Gender = "Female",
                      AnnualSalary = 9900
                },
                    new Employee
                {
                   EmployeeID = 106,
                      FirstName = "Sam",
                      LastName = "Kaur",
                      Gender = "Female",
                      AnnualSalary = 9880
                },

            };
            return listEmployee;
        }

    }
}
