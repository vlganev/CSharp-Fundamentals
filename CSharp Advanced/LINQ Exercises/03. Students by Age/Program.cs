using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_by_Age
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
                .Where(arr => 18 <= int.Parse(arr[2]) && int.Parse(arr[2]) <= 24)
                .ToList()
                .ForEach(arr => Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]}"));
        }
    }
}
