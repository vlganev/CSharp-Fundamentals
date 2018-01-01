/*
Write a program that receives some info from the console about people and their phone numbers.
You are free to choose the manner in which the data is stored.A valid entry should have just one name and one
number (both of them strings). If you receive a name that already exists in the phonebook, simply update its number.
After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a 
search of a contact by name and print his details in the format "{name} -> {number}". In case the contact isn't found, 
print "Contact {name} does not exist."  Search for contacts until you receive the command "stop".
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (input != "search")
            {
                var command = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = command[0];
                string number = command[1];
                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                else
                {
                    phonebook.Add(name, number);
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "stop")
            {
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
                input = Console.ReadLine();
            }
        }
    }
}
