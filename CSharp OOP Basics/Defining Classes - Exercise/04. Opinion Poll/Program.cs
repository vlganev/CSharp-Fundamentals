using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Person> family = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                family.Add(new Person(tokens[0], int.Parse(tokens[1])));
            }
            var results = family.Where(p => p.age > 30).OrderByDescending(x => x.name);
            foreach (var result in results)
            {
                Console.WriteLine($"{result.name} - {result.age}");
            }
        }
    }
}
