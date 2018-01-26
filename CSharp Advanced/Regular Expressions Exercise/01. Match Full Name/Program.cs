using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            while (text != "end")
            {
                Match match = regex.Match(text);
                if (match.Success)
                    Console.WriteLine(text);
                text = Console.ReadLine();
            }
        }
    }
}
