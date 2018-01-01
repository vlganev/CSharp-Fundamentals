/*
Find the count of 2 x 2 squares of equal chars in a matrix.
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrixSize[0]; row++)
            {
                var inputRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var allEqual = new[] { matrix[row, col], matrix[row, col + 1], matrix[row + 1, col], matrix[row + 1, col + 1] }.Distinct().Count();
                    if (allEqual == 1)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}

