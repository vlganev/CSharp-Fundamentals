using BashSoft.Judge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester.CompareContent(@"F:\SoftUni\CSharp-Fundamentals\CSharp Advanced\BashSoft\StoryMode\BashSoft\test2.txt", @"F:\SoftUni\CSharp-Fundamentals\CSharp Advanced\BashSoft\StoryMode\BashSoft\test3.txt");
        }
    }
}
