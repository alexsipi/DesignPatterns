using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Examples
{
    public static class LINQObjects
    {
        public static List<Company> CompanyList { get; set; } = new List<Company>();
        public static List<Employee> EmployeeList { get; set; } = new List<Employee>();

        public static IEnumerable<Employee> GetGoogleEmployees() {
            //Method 1
            var result1 = from employee in EmployeeList where employee.CompanyId == 1 select employee;
            //Method 2
            var result2 = (IEnumerable<Employee>)EmployeeList.Where(emp => emp.CompanyId == 1);

            return result2;
        }

        public static void DataLoad() {
            CompanyList.Add(new Company { Id = 1, Name = "Google" });
            CompanyList.Add(new Company { Id = 2, Name = "Apple" });

            EmployeeList.Add(new Employee { Id = 1, CompanyId = 1, Name = "Julien" });
            EmployeeList.Add(new Employee { Id = 2, CompanyId = 1, Name = "Anna" });
            EmployeeList.Add(new Employee { Id = 3, CompanyId = 2, Name = "John" });
            EmployeeList.Add(new Employee { Id = 4, CompanyId = 2, Name = "Maria" });
        }

        public static void print(IEnumerable<Employee> lst) {
            foreach (var i in lst)
            {
                Console.WriteLine(i.Name);
            }
        }

        public class Company
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Employee
        {
            public int Id { get; set; }
            public int CompanyId { get; set; }
            public string Name { get; set; }
        }
    }
}
