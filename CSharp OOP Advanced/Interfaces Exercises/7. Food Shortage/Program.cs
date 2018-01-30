using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        IList<IBuyer> list = new List<IBuyer>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 3)
            {
                IBuyer pet = new Rebel(tokens[0], tokens[1], tokens[2]);
                list.Add(pet);
            }
            else if (tokens.Length == 4)
            {
                IBuyer citizen = new Citizen(tokens[0], tokens[1], tokens[2], tokens[3]);
                list.Add(citizen);
            }
        }

        string whoBuyFood;
        while((whoBuyFood = Console.ReadLine()) != "End") {
            var buyer = list.Where(b => b.Name == whoBuyFood).FirstOrDefault();
            if (buyer != null)
            {
                buyer.BuyFood();
            }
        }

        int totalSum = list.Sum(b => b.Food);
        Console.WriteLine(totalSum);
    }
}