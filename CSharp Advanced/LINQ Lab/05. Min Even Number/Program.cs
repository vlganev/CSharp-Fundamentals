﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.WriteLine($"{Console.ReadLine().Split(' ').Select(double.Parse).Where(n => n % 2 == 0).Min():f2}");
            }
            catch (Exception)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
