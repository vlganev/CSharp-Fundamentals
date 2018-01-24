using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_Doubles
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            Console.WriteLine(numbers
                .Split(' ')
                .Select(double.Parse)
                .Average());
        }
    }
}
