using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string key = Console.ReadLine().ToLower();

            int indexOfKey = text.IndexOf(key);
            var occurances = 0;

            while (indexOfKey >= 0)
            {
                occurances++;
                indexOfKey = text.IndexOf(key, indexOfKey + 1);
            }
            Console.WriteLine(occurances);
        }
    }
}
