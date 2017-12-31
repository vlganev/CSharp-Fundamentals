/*
You are given an empty text. Your task is to implement 4 commands related to manipulating the text
•	1 someString - appends someString to the end of the text
•	2 count - erases the last count elements from the text
•	3 index - returns the element at position index from the text
•	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> previousCommands = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "1":
                        previousCommands.Push(text);
                        text += commands[1];
                        break;
                    case "2":
                        previousCommands.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(commands[1]));
                        break;
                    case "3":
                        Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                        break;
                    case "4":
                        text = previousCommands.Pop();
                        break;
                }
            }
        }
    }
}
