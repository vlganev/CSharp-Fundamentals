using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsNum = int.Parse(Console.ReadLine());
            Queue<Car> cars = new Queue<Car>();
            for (int i = 0; i < carsNum; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                cars.Enqueue(new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2])));
            }
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                cars.Where(c => c.Model == tokens[1]).ToList().ForEach(c => c.Drive(int.Parse(tokens[2])));
            }
            int count = cars.Count;
            for (int i = 0; i < count; i++)
            {
                Car car = cars.Dequeue();
                Console.WriteLine("{0} {1:F2} {2}", car.Model, car.FuelAmount, car.TotalKilometers);
            }
        }
    }
}
