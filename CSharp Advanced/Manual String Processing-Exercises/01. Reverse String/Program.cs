using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }

        private static string ReverseString(string input)
        {
            var sb = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return(sb.ToString());
        }
    }
}
