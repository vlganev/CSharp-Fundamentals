/*
You are given two jagged arrays.Each array represents a Lego block containing integers.
Your task is first to reverse the second jagged array and then check if it would fit perfectly in the first jagged array.  
The picture above shows exactly what fitting arrays mean.If the arrays fit perfectly you should print out the newly made 
rectangular matrix.If the arrays do not match (they do not form a rectangular matrix) you should print out the number of
cells in the first array and in the second array combined.The examples below should help you understand more the assignment.
Input
The first line of the input comes as an integer number n saying how many rows are there in both arrays. 
Then you have 2 * n lines of numbers separated by whitespace(s). The first n lines are the rows of the first jagged array; 
the next n lines are the rows of the second jagged array.There might be leading and/or trailing whitespace(s).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[][] firstJaggedArray = new int[lines][];
            int[][] secondJaggedArray = new int[lines][];

            for (int i = 0; i < lines; i++)
            {
                firstJaggedArray[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < lines; i++)
            {
                secondJaggedArray[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            bool fit = true;
            for (int i = 0; i < lines - 1; i++)
            {
                if (firstJaggedArray[i].Length + secondJaggedArray[i].Length != firstJaggedArray[i + 1].Length + secondJaggedArray[i + 1].Length)
                {
                    fit = false;
                    break;
                }
            }

            if (fit)
            {
                for (int i = 0; i < lines; i++)
                {
                    int[] combined = firstJaggedArray[i].Concat(secondJaggedArray[i].Reverse()).ToArray();
                    Console.WriteLine($"[{string.Join(", ", combined)}]");
                }
            }
            else
            {
                var num = 0;
                for (int i = 0; i < lines; i++)
                {
                    num += firstJaggedArray[i].Length + secondJaggedArray[i].Length;
                }
                Console.WriteLine($"The total number of cells is: {num}");
            }
        }
    }
}
