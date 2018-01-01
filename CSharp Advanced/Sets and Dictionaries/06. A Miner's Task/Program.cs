/*
You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource 
(e.g. Gold, Silver, Copper, and so on) , and every even – quantity. Keep reading lines from the console until 
you receive the command "stop". Your task is to collect the resources and print them each on a new line. 
Print the resources and their quantities in format:   “{resource} –> {quantity}”
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_s_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> miner = new Dictionary<string, decimal>();

            bool canContinue = true;
            int count = 0;
            string addKey = "";
            while (canContinue)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    foreach (var item in miner)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    canContinue = false;
                    break;
                }
                if (count % 2 == 0)
                {
                    if (!miner.ContainsKey(input))
                    {
                        miner[input] = 0;
                        addKey = input;
                    }
                    else
                    {
                        addKey = input;
                    }
                }
                else
                {
                    decimal inputDec = decimal.Parse(input);
                    miner[addKey] += inputDec;
                }
                count++;
            }
        }
    }
}
