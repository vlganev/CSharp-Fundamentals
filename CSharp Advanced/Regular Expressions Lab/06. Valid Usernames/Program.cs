using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"^[\w\d-]{3,16}$";
            Regex regex = new Regex(pattern);
            while (text != "END")
            {
                MatchCollection matches = regex.Matches(text);
                if (matches.Count > 0)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("invalid");
                text = Console.ReadLine();
            }
        }
    }
}
