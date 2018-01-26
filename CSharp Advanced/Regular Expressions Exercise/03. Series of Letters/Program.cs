using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"(.)\1+");
            Console.WriteLine(regex.Replace(text, "$1"));
        }
    }
}
