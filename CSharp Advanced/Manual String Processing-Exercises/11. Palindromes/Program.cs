using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", palindromes));
        }
        private static bool IsPalindrome(string text)
        {
            for (int i = 0; i <= (text.Length - 1) / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
