﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> myCustomList = new CustomList<string>();
            string inputLine;
            while((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split(' ');

                switch (tokens[0])
                {
                    case "Add":
                        myCustomList.Add(tokens[1]);
                        break;
                    case "Remove":
                        myCustomList.Remove(int.Parse(tokens[1]));
                        break;
                    case "Contains":
                            Console.WriteLine(myCustomList.Contains(tokens[1]) ? "True" : "False");
                        break;
                    case "Swap":
                        myCustomList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(myCustomList.CountGreaterThan(tokens[1]));
                        break;
                    case "Max":
                        Console.WriteLine(myCustomList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(myCustomList.Min());
                        break;
                    case "Print":
                        foreach (var element in myCustomList)
                        {
                            Console.WriteLine(element);
                        }
                        break;
                    case "Sort":
                        myCustomList = Sorter.Sort(myCustomList);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
