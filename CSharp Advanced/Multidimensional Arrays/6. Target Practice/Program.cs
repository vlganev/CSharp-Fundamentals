/*
Cotton-eye Gosho has a problem. Snakes! An infestation of snakes! Gosho is a red-neck which means he doesn’t 
really care about animal rights, so he bought some ammo, loaded his shotgun and started shooting at the poor creatures. 
He has a favorite spot – rectangular stairs which the snakes like to climb in order to reach Gosho’s stash of 
whiskey in the attic. You’re tasked with the horrible cleanup of the aftermath.
A snake is represented by a string. The stairs are a rectangular matrix of size NxM. A snake starts climbing 
the stairs from the bottom-right corner and slithers its way up in a zigzag – first it moves left until it 
reaches the left wall, it climbs on the next row and starts moving right, then on the third row, moving left 
again and so on. The first cell (bottom-right corner) is filled with the first symbol of the snake, the second cell 
(to the left of the first) is filled with the second symbol, etc. The snake is as long as it takes in order to fill
the stairs completely – if you reach the end of the string representing the snake, start again at the beginning. 
Gosho is patient and a sadist, he’ll wait until the stairs are completely covered with snakes and then will fire a shot.
The shot has three parameters – impact row, impact column and radius. When the projectile lands on the specified
coordinates in the matrix it destroys all symbols in the given radius (turns them into a space). You can check whether 
a cell is inside the blast radius using the Pythagorean Theorem (very similar to the "point inside a circle" problem).
The symbols above the impact area start falling down until they land on other symbols (meaning a symbol moves down a row 
as long as there is a space below). When the horror ends, print on the console the resulting staircase, each row on a new line. 
You should really check out the examples at this point.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var matixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            Queue<char> stackQueue = new Queue<char>();
            var cellAndShot = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int landCellRow = cellAndShot[0];
            int landCellCol = cellAndShot[1];
            int impact = cellAndShot[2];

            int rows = matixSize[0];
            int cols = matixSize[1];
            int totalChars = rows * cols;
            int index = 0;
            for (int i = 0; i < totalChars; i++)
            {
                index = i % snake.Length;
                stackQueue.Enqueue(snake[index]);
            }

            char[][] matrix = new char[rows][];

            ArrangeMatrix(stackQueue, rows, cols, matrix);

            Bomb(landCellRow, landCellCol, impact, matrix);
            Gravity(matrix);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var arr in matrix)
            {
                Console.WriteLine(string.Join("", arr));
            }
        }

        private static void ArrangeMatrix(Queue<char> stackQueue, int rows, int cols, char[][] matrix)
        {
            for (int row = rows - 1; 0 <= row; row--)
            {
                matrix[row] = new char[cols];
                if (rows % 2 == 0)
                {
                    int col = 0;
                    if (row % 2 == 1)
                    {
                        for (col = cols - 1; 0 <= col; col--)
                        {
                            matrix[row][col] = stackQueue.Dequeue();
                        }
                    }
                    else
                    {
                        for (col = 0; col < cols; col++)
                        {
                            matrix[row][col] = stackQueue.Dequeue();
                        }
                    }
                }
                else
                {
                    int col = 0;
                    if (row % 2 == 1)
                    {
                        for (col = 0; col < cols; col++)
                        {
                            matrix[row][col] = stackQueue.Dequeue();
                        }
                    }
                    else
                    {
                        for (col = cols - 1; 0 <= col; col--)
                        {
                            matrix[row][col] = stackQueue.Dequeue();
                        }
                    }
                }
            }
        }

        private static void Gravity(char[][] matrix)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                Stack<char> currentCol = new Stack<char>();
                for (int row = 0; row < matrix.Length; row++)
                {
                    char currentChar = matrix[row][col];
                    if (currentChar != ' ')
                    {
                        currentCol.Push(currentChar);
                        matrix[row][col] = ' ';
                    }
                }

                for (int roww = matrix.Length - 1; roww >= 0; roww--)
                {
                    if (currentCol.Count > 0)
                    {
                        matrix[roww][col] = currentCol.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void Bomb(int landCellRow, int landCellCol, int impact, char[][] matrix)
        {
            if (impact == 0)
            {
                matrix[landCellRow][landCellCol] = ' ';
            }
            else
            {
                for (int r = 0; r < matrix.Length; r++)
                {
                    for (int c = 0; c < matrix[0].Length; c++)
                    {
                        if (((r - landCellRow) * (r - landCellRow) + (c - landCellCol) * (c - landCellCol)) <= impact * impact)
                        {
                            matrix[r][c] = ' ';
                        }
                    }
                }
            }
        }
    }
}
