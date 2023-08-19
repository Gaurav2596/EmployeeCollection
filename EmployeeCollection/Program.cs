using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeCRUD crud = new EmployeeCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Update Employee");
                Console.WriteLine("3.Delete Employee");
                Console.WriteLine("4.Display All Details");
                int op=Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Emp ID");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Emp name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Emp Salary");
                        e1.Salary = Convert.ToDouble(Console.ReadLine());

                        crud.AddEmployee(e1);
                        break;

                    case 2:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter id to modify");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Emp Name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Emp Salary");
                        e2.Salary = Convert.ToDouble(Console.ReadLine());

                        crud.UpdateEmployee(e2);
                        break;

                    case 3:
                        Console.WriteLine("Enter id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(id);
                        break;

                    case 4:
                        List<Employee> list = crud.GetEmployees();
                        foreach (Employee e in list)
                        {
                            Console.WriteLine($"{e.Id}-->{e.Name}-->{e.Salary}");
                            
                        }
                        break;

                        
                }
                Console.WriteLine("Press 1 for continue");
                option = Convert.ToInt32(Console.ReadLine());

            }
            while (option==1);
        }
    }
}
