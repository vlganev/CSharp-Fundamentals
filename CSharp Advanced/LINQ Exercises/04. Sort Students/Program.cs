using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Students
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
                .OrderBy(arr => arr[1])
                .ThenByDescending(arr => arr[0])
                .ToList()
                .ForEach(arr => Console.WriteLine($"{arr[0]} {arr[1]}"));
        }
    }
}
