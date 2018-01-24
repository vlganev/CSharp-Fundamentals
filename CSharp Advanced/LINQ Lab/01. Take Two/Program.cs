using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Take_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            numbers
                .Where(x => x >= 10 && x <= 20)
                .Distinct()
                .Take(2)
                .ToList()
                .ForEach(n => Console.WriteLine(n + " "));
        }
    }
}
