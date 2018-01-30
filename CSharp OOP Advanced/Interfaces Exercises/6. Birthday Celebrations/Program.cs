using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        IList<IBirthDate> list = new List<IBirthDate>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 3 && tokens[0] == "Pet")
            {
                IBirthDate pet = new Pet(tokens[1], tokens[2]);
                list.Add(pet);
            }
            else if (tokens.Length == 5)
            {
                IBirthDate citizen = new Citizen(tokens[1], tokens[2], tokens[3], tokens[4]);
                list.Add(citizen);
            }
        }
        string birthYear = Console.ReadLine();
        foreach (var people in list)
        {
            if (people.BirthDate.EndsWith(birthYear))
            {
                Console.WriteLine(people.BirthDate);
            }
        }
    }
}