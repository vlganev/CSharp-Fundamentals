using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is calculated from 
the sum of the two previous elements. The first two elements are 1, 1. Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34… 
The following sequence can be generated with an array, but that’s easy, so your task is to implement recursively.
*/
namespace Recursive_Fibonacci
{
    class Program
    {
        static long[] fibonacci;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fibonacci = new long[n];
            fibonacci[0] = 1;
            if (n > 1) fibonacci[1] = 1;
            Console.WriteLine(GetFibonacci(n - 1));
        }

        static long GetFibonacci(int n)
        {
            if (fibonacci[n] == 0)
                fibonacci[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            return fibonacci[n];
        }
    }
}
