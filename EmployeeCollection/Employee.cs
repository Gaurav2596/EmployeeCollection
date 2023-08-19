using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollection
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double  Salary { get; set; }
    }
    public class EmployeeCRUD
    {
        private List<Employee> employees;
        public EmployeeCRUD()
        {
            employees = new List<Employee>();

        }
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public void UpdateEmployee(Employee emp)
        {
            foreach (Employee e in employees)
            {
                if (e.Id == emp.Id)
                {
                    e.Name = emp.Name;
                    e.Salary = emp.Salary;
                    break;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            foreach (Employee e in employees)
            {
                if (e.Id == id)
                {
                    employees.Remove(e);
                    break;
                }
            }
        }
        public List<Employee>GetEmployees()
        {
            return employees;
        }

    }
}
