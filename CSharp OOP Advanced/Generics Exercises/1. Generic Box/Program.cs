using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Generic_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            IList<Box<string>> listOfBoxes = new List<Box<string>>();
            for (int i = 0; i < numberOfLines; i++)
            {
                Box<string> boxStr = new Box<string>(Console.ReadLine());
                listOfBoxes.Add(boxStr);
            }
            int[] indexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            SwapElements(listOfBoxes, indexes[0], indexes[1]);

            foreach (var box in listOfBoxes)
            {
                Console.WriteLine(box);
            }
        }

        private static void SwapElements<T>(IList<Box<T>> listOfBoxes, int index1, int index2)
        {
            Box<T> tempBox = listOfBoxes[index1];
            listOfBoxes[index1] = listOfBoxes[index2];
            listOfBoxes[index2] = tempBox;
        }
    }
}
