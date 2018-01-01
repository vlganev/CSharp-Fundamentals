/*
Write a program that finds the difference between the sums of the square matrix diagonals(absolute value)  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            long diagonalSum1 = 0;
            long diagonalSum2 = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonalSum1 += matrix[i, i];
                diagonalSum2 += matrix[matrix.GetLength(0) - i-1, i];
            }
            Console.WriteLine(Math.Abs(diagonalSum1-diagonalSum2));
        }
    }
}
