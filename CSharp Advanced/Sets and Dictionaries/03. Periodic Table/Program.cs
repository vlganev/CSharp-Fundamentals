/*
You are given an n number of chemical compounds. You need to keep track of all chemical elements used in the 
compounds and at the end print all unique ones in ascending order:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> allChemicalCompounds = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] chemicalCompounds = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in chemicalCompounds)
                {
                    allChemicalCompounds.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", allChemicalCompounds));
        }
    }
}
