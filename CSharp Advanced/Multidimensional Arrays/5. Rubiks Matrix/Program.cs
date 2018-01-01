/*
Rubik’s cube – everyone’s favorite head-scratcher. Writing a program to solve it will be quite a difficult task for an exam, though. Instead, we have a Rubik’s matrix prepared for you. You will be given a pair of dimensions: R and C. To prepare the matrix, fill each row with increasing integers, starting from one. For example, 2 x 4 matrix must look like this:
1	2	3	4
5	6	7	8


Next, you will receive series of commands, indicating which row or column you must move, in which direction, and how many times. For example, 1 up 1 means: column 1, direction: up, 1 move. After executing it, the matrix should look like:
1	6	3	4
5	2	7	8


Directions left and right means you must move the corresponding row, while up and down are related to the columns. After shuffling the Rubik’s matrix, you have to rearrange it (meaning that the values in each cell should be in increasing order, such as the ones in the original matrix). The rearranging process should start at top-left and end at bottom-right. Find the position of the value you need, and print the swap command on the console, in the format described below.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubiks_Matrix
{
    class Program
    {
        private static void Main(string[] args)
        {
            var inputArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var r = inputArgs[0];
            var c = inputArgs[1];

            var commandCount = int.Parse(Console.ReadLine());
            int[][] matrix = new int[r][];

            int num = 1;

            for (int i = 0; i < r; i++)
            {
                matrix[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    matrix[i][j] = num;
                    num++;
                }
            }

            for (int l = 0; l < commandCount; l++)
            {
                var commandArgs = Console.ReadLine().Split();
                var rowCol = int.Parse(commandArgs[0]);
                var direction = commandArgs[1];
                var moves = int.Parse(commandArgs[2]);

                if (direction == "down" || direction == "up")
                {
                    moves = moves % matrix.Length;
                    MoveColumnValues(rowCol, direction, moves, matrix);
                }
                else if (direction == "left" || direction == "right")
                {
                    moves = moves % matrix[0].Length;
                    MoveRowValues(rowCol, direction, moves, matrix);
                }

                //PrintMatrix(matrix);//Testing
            }

            RearrangeMatrix(matrix);
            //PrintMatrix(matrix);//Testing
        }

        private static void RearrangeMatrix(int[][] matrix)
        {
            var correctValue = 1;
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    if (matrix[r][c] != correctValue)
                    {
                        SwapValues(r, c, correctValue, matrix);
                        //Console.WriteLine();//Testing
                        //PrintMatrix(matrix);//Testing
                        //Console.WriteLine();//Testing
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                    correctValue++;
                }
            }
        }

        private static void SwapValues(int r, int c, int correctValue, int[][] matrix)
        {
            var swapRowIndex = 0;
            var swapColIndex = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (matrix[row][col] == correctValue)
                    {
                        swapRowIndex = row;
                        swapColIndex = col;
                        break;
                    }
                }
            }

            var swapValue = matrix[r][c];
            matrix[r][c] = matrix[swapRowIndex][swapColIndex];
            matrix[swapRowIndex][swapColIndex] = swapValue;
            Console.WriteLine($"Swap ({r}, {c}) with ({swapRowIndex}, {swapColIndex})");
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach (var arr in matrix)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
        }

        private static void MoveRowValues(int rowCol, string direction, int moves, int[][] matrix)
        {
            if (moves == matrix[rowCol].Length || moves == 0)
            {
                return;
            }

            if (direction == "left")
            {
                for (int i = 0; i < moves; i++)
                {
                    var tempValue = matrix[rowCol][0];
                    for (int j = 0; j < matrix[rowCol].Length; j++)
                    {
                        if (j == matrix[rowCol].Length - 1)
                        {
                            matrix[rowCol][j] = tempValue;
                        }
                        else
                        {
                            matrix[rowCol][j] = matrix[rowCol][j + 1];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < moves; i++)
                {
                    var tempValue = matrix[rowCol][matrix[rowCol].Length - 1];
                    for (int j = matrix[rowCol].Length - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            matrix[rowCol][j] = tempValue;
                        }
                        else
                        {
                            matrix[rowCol][j] = matrix[rowCol][j - 1];
                        }
                    }
                }
            }
        }

        private static void MoveColumnValues(int rowCol, string direction, int moves, int[][] matrix)
        {
            if (moves == matrix.Length || moves == 0)
            {
                return;
            }

            if (direction == "up")
            {
                for (int i = 0; i < moves; i++)
                {
                    var tempValue = matrix[0][rowCol];
                    for (int j = 0; j < matrix.Length; j++)
                    {
                        if (j == matrix.Length - 1)
                        {
                            matrix[j][rowCol] = tempValue;
                        }
                        else
                        {
                            matrix[j][rowCol] = matrix[j + 1][rowCol];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < moves; i++)
                {
                    var tempValue = matrix[matrix.Length - 1][rowCol];
                    for (int j = matrix.Length - 1; j >= 0; j--)
                    {
                        if (j == 0)
                        {
                            matrix[j][rowCol] = tempValue;
                        }
                        else
                        {
                            matrix[j][rowCol] = matrix[j - 1][rowCol];
                        }
                    }
                }
            }
        }
    }
}