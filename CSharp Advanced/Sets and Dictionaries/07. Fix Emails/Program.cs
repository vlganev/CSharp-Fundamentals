/*
You are given a sequence of strings, each on a new line, unitll you receive the "stop" command. 
The first string is a name of a person. On the second line you will receive his email. Your task is 
to collect their names and emails, and remove the entries whose email’s domain ends with "us" or "uk" (case insensitive). 
Print all the collected people and their emails in the following format: “{name} –> {email}”
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailDB = new Dictionary<string, string>();
            bool canContinue = true;
            while (canContinue)
            {
                string name = Console.ReadLine();
                string email = "";
                if (name.ToLower() == "stop")
                {
                    canContinue = false;
                    break;
                }
                else
                {
                    email = Console.ReadLine();
                }

                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    break;
                }

                if (emailDB.ContainsKey(name))
                {
                    emailDB[name] = email;
                }
                else
                {
                    emailDB.Add(name, email);
                    Console.WriteLine($"{name} -> {email}");
                }
            }
        }
    }
}
