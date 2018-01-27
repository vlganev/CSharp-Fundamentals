using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Stack<Employee> employees = new Stack<Employee>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string position = tokens[2];
                string department = tokens[3];
                if (tokens.Length == 4)
                {
                    employees.Push(new Employee(name, salary, position, department));
                }
                else if (tokens.Length == 5)
                {
                    int age;
                    bool isAge = int.TryParse(tokens[4], out age);
                    if (isAge)
                    {
                        employees.Push(new Employee(name, salary, position, department, age));
                    }
                    else
                    {
                        string email = tokens[4];
                        employees.Push(new Employee(name, salary, position, department, email));
                    }
                }
                else
                {
                    string email = tokens[4];
                    int age = int.Parse(tokens[5]);
                    employees.Push(new Employee(name, salary, position, department, email, age));
                }
            }

            if (employees.Count == 0)
            {
                return;
            }
            var highestAverageSalaryDepartment = employees
                .GroupBy(e => e.Department)
                .OrderByDescending(g => g.Select(e => e.Salary).Sum())
                .First();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Key}");
            Console.WriteLine(string.Join(Environment.NewLine, highestAverageSalaryDepartment
                .OrderByDescending(e => e.Salary)
                .Select(e => $"{e.Name} {e.Salary:F2} {e.Email} {e.Age}")));
        }
    }
}
