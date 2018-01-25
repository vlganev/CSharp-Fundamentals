using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_by_First_and_Last_Name
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
                .Where(s => String.Compare(s[0], s[1]) == -1)
                .ToList()
                .ForEach(arr => Console.WriteLine($"{arr[0]} {arr[1]}"));
        }
    }
}
