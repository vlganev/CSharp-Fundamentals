using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Enrolled_in_2014_or_2015
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
                .Where(arr => arr[0].EndsWith("14") || arr[0].EndsWith("15"))
                .ToList()
                .ForEach(arr => Console.WriteLine($"{arr[1]} {arr[2]} {arr[3]} {arr[4]}"));
        }
    }
}
