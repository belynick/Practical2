using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new Employee("Працiвник А", 5200, 7);
            Employee employeeB = new Employee("Працiвник Б", 3700, 4);
            Employee employeeC = new Employee("Працiвник В", 11900, 12);
            Employee employeeD = new Employee("Працiвник Г", 4500, 5);
            Employee employeeE = new Employee("Працiвник Д", 2500, 3);
            Employee employeeF = new Employee("Працiвник Ж", 4300, 6);

            List<Employee> employees = new List<Employee>()
            { employeeA, employeeB, employeeC, employeeD, employeeE, employeeF};
            Console.WriteLine("Несортированi робiтники: ");

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}, зарплата: {employee.Salary}, роки досвiду: {employee.Experience}");
            }

            Console.WriteLine();
            Console.WriteLine("Сортировання за зарплатою:");

            var selectedBySalary = employees.OrderByDescending(x => x.Salary).ThenBy(x => x.Salary).ToList();
            foreach (var employee in selectedBySalary)
            {
                Console.WriteLine($"{employee.Name}, зарплата: {employee.Salary}, роки досвiду: {employee.Experience}");
            }

            Console.WriteLine();
            Console.WriteLine("Сортировання за роками досвiду:");

            var selectedByExperience = employees.OrderByDescending(x => x.Experience).ThenBy(x => x.Experience).ToList();
            foreach (var employee in selectedByExperience)
            {
                Console.WriteLine($"{employee.Name}, зарплата: {employee.Salary}, роки досвiду: {employee.Experience}");
            }

            Console.ReadLine();
        }
    }
}
