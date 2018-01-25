using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weak_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new List<string[]>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                group.Add(input.Split(' '));
                input = Console.ReadLine();
            }
            group
                .Where(arr => arr.Skip(2).Count(mark => int.Parse(mark) <= 3) >=2) 
                .ToList()
                .ForEach(arr => Console.WriteLine($"{arr[0]} {arr[1]}"));
        }
    }
}
