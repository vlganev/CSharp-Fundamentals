using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '\n', '\r', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var num1 = int.Parse(input[0]);
            var num2 = double.Parse(input[1]);
            var num3 = double.Parse(input[2]);
            var num1Binary = Convert.ToString(num1, 2);
            if (num1Binary.Length > 10)
            {
                num1Binary = num1Binary.Substring(0, 10);
            }
            Console.WriteLine($"|{num1,-10:X}|{num1Binary.PadLeft(10, '0')}|{num2,10:f2}|{num3,-10:f3}|");
        }
    }
}
