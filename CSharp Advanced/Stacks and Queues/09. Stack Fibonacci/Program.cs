/*
There is another way of calculating the Fibonacci sequence using a stack. It is non recursive, so it does not 
make any unnecessary calculations. Try implementing it. This time set the Fibonacci sequence to start from 0, 
i.e. 0, 1, 1, 2, 3, 5, 8… and so on. First push 0 and 1 and then use popping, peeking and pushing to generate every consecutive number. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nthNumber = int.Parse(Console.ReadLine());
            Stack<long> stackFib = new Stack<long>();
            stackFib.Push(0);
            stackFib.Push(1);
            for (int i = 1; i < nthNumber; i++)
            {
                long firstNum = stackFib.Pop();
                long secondNum = stackFib.Pop();
                stackFib.Push(firstNum);
                stackFib.Push(firstNum + secondNum);
            }
            Console.WriteLine(stackFib.Peek());
        }
    }
}
