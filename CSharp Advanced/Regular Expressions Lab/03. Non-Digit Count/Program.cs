using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Non_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"[\D]";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            int count = matches.Count;
            Console.WriteLine($"Non-digits: {count}");
        }
    }
}
