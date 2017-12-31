/*
Given a sequence consisting of parentheses, determine whether the expression is balanced. 
A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with 
a closed parenthesis that occurs after the former. Also, the interval between them must be balanced. 
You will be given three types of parentheses: (, {, and [.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isParentheses = false;
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var ch in input)
            {
                if (ch == '{' || ch == '[' || ch == '(')
                {
                    stack.Push(ch);
                }
                else
                {
                    char currStackCh = stack.Pop();
                    if ((currStackCh == '{' && ch == '}') || (currStackCh == '[' && ch == ']') || (currStackCh == '(' && ch == ')'))
                    {
                        isParentheses = true;
                    }
                    else
                    {
                        isParentheses = false;
                        break;
                    }
                }
            }
            if (isParentheses)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
