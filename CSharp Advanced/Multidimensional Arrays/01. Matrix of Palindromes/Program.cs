/*
Write a program to generate and print the following matrix of palindromes of 3 letters with r rows and c columns like at the examples below.
•	Rows define the first and the last letter: row 0  ‘a’, row 1  ‘b’, row 2  ‘c’, …
•	Columns + rows define the middle letter: 
o	column 0, row 0  ‘a’, column 1, row 0  ‘b’, column 2, row 0  ‘c’, …
o	column 0, row 1  ‘b’, column 1, row 1  ‘c’, column 2, row 1  ‘d’, …
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrixSize[0]; row++)
            {
                for (int col = 0; col < matrixSize[1]; col++)
                {
                    string value = $"{alphabet[row]}{alphabet[col+row]}{alphabet[row]}";
                    matrix[row, col] = value;
                }
            }

            for (int row = 0; row < matrixSize[0]; row++)
            {
                for (int col = 0; col < matrixSize[1]; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
