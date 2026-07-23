using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            //Add data on table employees
            Employee E1 = new Employee();
            E1.EmpName = "Alwaleed";
            E1.EmployeeSalary = 2000;
            E1.EmployeeSsn = 202;
            E1.EmployeeAge = 23;
            context.employees.Add(E1);
            context.SaveChanges();

            //Case 1: Register Employee
            Employee E2 = new Employee();
            Console.WriteLine("Eegister user");
            Console.WriteLine("Enter name: ");
            E1.EmpName = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            E1.EmployeeAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Salary: ");
            E1.EmployeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter SSN: ");
            E1.EmployeeSsn = int.Parse(Console.ReadLine());

            context.employees.Add(E1);
            context.SaveChanges();

            //Case 2: delete employee
            Console.WriteLine("Enter Employee ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Employee employee = context.employees.FirstOrDefault(e => e.EmployeeId == id);

            if (employee == null)
            {
                Console.WriteLine("Employee does not exist");
            }
            else
            {
                context.employees.Remove(employee);
                context.SaveChanges();
            }


            //Case 3: Update Employee
            Console.WriteLine("Enter Employee Id to edit: ");
            int id2 = int.Parse(Console.ReadLine());
            Employee employee1 = context.employees.FirstOrDefault(e => e.EmployeeId == id2);
            if (employee1 == null)
            {
                Console.WriteLine("Employee does not exist");
            }
            else
            {
                Console.WriteLine("Enter the new name: ");
                employee1.EmpName = Console.ReadLine();

                Console.WriteLine("Enter the new SSN: ");
                employee1.EmployeeSsn = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the new Salary: ");
                employee1.EmployeeSalary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the new Age: ");
                employee1.EmployeeAge = int.Parse(Console.ReadLine());

                context.SaveChanges();

                Console.WriteLine("Employee Updated Successfully.");

            }
        }
    }
}
