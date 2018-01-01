/*
On the first line you are given the length of two sets n and m. On the next n + m lines there are n numbers that 
are in the first set and m numbers that are in the second one. Find all non-repeating elements that appear in both of them, 
and print them at the console:
Set with length n = 4: {1, 3, 5, 7}
Set with length m = 3: {3, 4, 5}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lines = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            int sizeN = lines[0];
            int sizeM = lines[1];
            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();
            for (int i = 0; i < sizeN; i++)
                setN.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < sizeM; i++)
                setM.Add(int.Parse(Console.ReadLine()));
            setN.IntersectWith(setM);
            Console.WriteLine(string.Join(" ", setN));
        }
    }
}
