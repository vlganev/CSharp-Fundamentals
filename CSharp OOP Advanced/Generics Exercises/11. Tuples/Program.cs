using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ');
            var names = $"{inputLine[0]} {inputLine[1]}";
            var address = inputLine[2];
            var nameAddress = new Tuple<string, string>(names, address);
            Console.WriteLine(nameAddress);

            inputLine = Console.ReadLine().Split(' ');
            var name = inputLine[0];
            var liters = int.Parse(inputLine[1]);
            var nameLiters = new Tuple<string, int>(name, liters);
            Console.WriteLine(nameLiters);

            inputLine = Console.ReadLine().Split(' ');
            var integer = int.Parse(inputLine[0]);
            var doubleNum = double.Parse(inputLine[1]);
            var newT = new Tuple<int, double>(integer, doubleNum);
            Console.WriteLine(newT);
        }
    }
}
