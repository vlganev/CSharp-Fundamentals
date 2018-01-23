using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"^(([1][0-2]|[0][0-9]):[0-5][0-9]:[0-5][0-9] [AP]M)$";
            Regex regex = new Regex(pattern);
            while (text != "END")
            {
                Match match = regex.Match(text);
                if (match.Success)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("invalid");
                text = Console.ReadLine();
            }
        }
    }
}
