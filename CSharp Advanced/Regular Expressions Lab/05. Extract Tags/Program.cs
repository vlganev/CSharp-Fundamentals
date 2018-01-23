using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "END")
            {

                string pattern = @"<.+?>";

                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(text);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }
                text = Console.ReadLine();
            }
        }
    }
}

