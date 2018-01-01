/*
Marian is a famous system administrator. The person to overcome the security of his servers has not yet been born. 
However, there is a new type of threat where users flood the server with messages and are hard to be detected since 
they change their IP address all the time. Well, Marian is a system administrator and he is not so into programming. 
Therefore, he needs a skillful programmer to track the user logs of his servers. You are the chosen one to help him!
You are given an input in the format:
IP={IP.Address} message=’{A&sample&message}’ user={username}
Your task is to parse the IP and the username from the input. For every user you have to display every IP from which 
this user has sent a message and the count of the messages sent from the corresponding IP. The usernames must be sorted 
alphabetically while their IP addresses should be displayed in the order of their first appearance. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> mails = new SortedDictionary<string, SortedDictionary<string, int>>();
            bool canContinue = true;

            while (canContinue)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    canContinue = false;
                    break;
                }
                List<string> lineData = input.Split(' ').ToList();
                string user = lineData[2].Substring(5);
                string IP = lineData[0].Substring(3);

                if (!mails.ContainsKey(user))
                {
                    mails.Add(user, new SortedDictionary<string, int>());
                }
                if (!mails[user].ContainsKey(IP))
                {
                    mails[user].Add(IP, 1);
                }
                else
                {
                    mails[user][IP] += 1;
                }

            }
            foreach (var user in mails)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var IP in user.Value)
                {
                    var thing = IP.Key;
                    if (IP.Key != user.Value.Keys.Last()) Console.Write($"{IP.Key} => {IP.Value}, ");
                    else Console.WriteLine($"{IP.Key} => {IP.Value}.");
                }
            }
        }
    }
}
