using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filteredWords = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in filteredWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
