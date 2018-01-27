using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lines = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Rectangle[] rect = new Rectangle[lines[0]];
            for (int i = 0; i < lines[0]; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                rect[i] = new Rectangle(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4]));
            }

            for (int i = 0; i < lines[1]; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Rectangle rect1 = rect.Where(r => r.Id == input[0]).FirstOrDefault();
                Rectangle rect2 = rect.Where(r => r.Id == input[1]).FirstOrDefault();

                Console.WriteLine(rect1.IsThereIntersection(rect2) ? "true" : "false");
            }
        }
    }
}
