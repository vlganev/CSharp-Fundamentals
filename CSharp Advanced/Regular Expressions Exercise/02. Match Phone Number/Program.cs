using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
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
