using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine();
            words.Split(' ')
                .Select(n => n.ToUpper())
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
    }
}
