using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var engines = GetEngines();
            var cars = GetCars(engines);
            PrintCars(cars, engines);
            
        }

        private static Engine[] GetEngines()
        {
            int engineCount = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[engineCount];
            for (int i = 0; i < engineCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int power = int.Parse(tokens[1]);

                if (tokens.Count() == 2)
                {
                    engines[i] = new Engine(model, power);
                }
                else if (tokens.Count() == 3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(tokens[2], out displacement);
                    if (isDisplacement)
                    {
                        engines[i] = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = tokens[2];
                        engines[i] = new Engine(model, power, efficiency);
                    }
                }
                else if (tokens.Length == 4)
                {
                    int displacement = int.Parse(tokens[2]);
                    string efficiency = tokens[3];
                    engines[i] = new Engine(model, power, displacement, efficiency);
                }
            }
            return engines;
        }

        private static Car[] GetCars(Engine[] engines)
        {
            int carsCount = int.Parse(Console.ReadLine());
            Car[] cars = new Car[carsCount];
            for (int i = 0; i < carsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                Engine engineModel = engines.Where(x => x.Model == tokens[1]).FirstOrDefault();

                if (tokens.Count() == 2)
                {
                    cars[i] = new Car(model, engineModel);
                }
                else if (tokens.Count() == 3)
                {
                    int weight;
                    bool isDisplacement = int.TryParse(tokens[2], out weight);
                    if (isDisplacement)
                    {
                        cars[i] = new Car(model, engineModel, weight);
                    }
                    else
                    {
                        string color = tokens[2];
                        cars[i] = new Car(model, engineModel, color);
                    }
                }
                else if (tokens.Length == 4)
                {
                    int displacement = int.Parse(tokens[2]);
                    string efficiency = tokens[3];
                    cars[i] = new Car(model, engineModel, displacement, efficiency);
                }
            }
            return cars;
        }

        private static void PrintCars(Car[] cars, Engine[] engines)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i].ToString());
            }
        }
    }
}
