﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Dispatcher dispatcher = new Dispatcher();
        Handler handler = new Handler();

        dispatcher.NameChange += handler.OnDispatcherNameChange;

        string name = Console.ReadLine();
        while(name != "End")
        {
            dispatcher.Name = name;
            name = Console.ReadLine();
        }
    }
}
