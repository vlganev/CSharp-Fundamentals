using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        IList<IIdentifiable> list = new List<IIdentifiable>();

        string input;

        while((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 2)
            {
                IIdentifiable robot = new Robot(tokens[0], tokens[1]);
                list.Add(robot);
            }
            else if (tokens.Length == 3)
            {
                IIdentifiable citizen = new Citizen(tokens[0], tokens[1], tokens[2]);
                list.Add(citizen);
            }
        }
        string fakeIdNum = Console.ReadLine();
        foreach (var identifiable in list)
        {
            if (identifiable.Id.EndsWith(fakeIdNum))
            {
                Console.WriteLine(identifiable.Id);
            }
        }
    }
}