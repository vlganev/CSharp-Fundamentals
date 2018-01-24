using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_and_Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var numbers = input
                .Split(' ')
                .Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new { value, success };
                })
                .Where(s => s.success)
                .Select(n => n.value)
                .ToList();

            if (numbers.Count != 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
