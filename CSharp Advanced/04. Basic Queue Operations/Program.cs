/*
Problem 4.	Basic Queue Operations
You will be given an integer N representing the amount of elements to enqueue (add), 
an integer S representing the amount of elements to dequeue (remove/poll) from the queue and 
finally an integer X, an element that you should check whether is present in the queue.
If it is print true on the console, if it’s not print the smallest element currently present in the queue.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < commands[0] && i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < commands[1] && queue.Count > 0; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Count == 0 ? "0" : queue.Contains(commands[2]) ? "true" : $"{queue.Min()}");
        }
    }
}
