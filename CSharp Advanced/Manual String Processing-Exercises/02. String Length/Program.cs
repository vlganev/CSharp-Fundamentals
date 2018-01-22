using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text.Length < 20)
            {
                text = text.PadRight(20, '*');
            }
            else if (text.Length > 20)
            {
                text = text.Substring(0, 20);
            }
            Console.WriteLine(text);
        }
    }
}
