using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numbers];
            for (int i = 0; i < numbers; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                double tyre1Pressure = double.Parse(tokens[5]);
                int tyre1Age = int.Parse(tokens[6]);
                double tyre2Pressure = double.Parse(tokens[7]);
                int tyre2Age = int.Parse(tokens[8]);
                double tyre3Pressure = double.Parse(tokens[9]);
                int tyre3Age = int.Parse(tokens[10]);
                double tyre4Pressure = double.Parse(tokens[11]);
                int tyre4Age = int.Parse(tokens[12]);
                
                cars[i] = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), new List<Tyre> { new Tyre(tyre1Pressure, tyre1Age), new Tyre(tyre2Pressure, tyre2Age), new Tyre(tyre3Pressure, tyre3Age), new Tyre(tyre4Pressure, tyre4Age) } );
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                cars
                    .Where(c => c.cargo.cargoType == "fragile")
                    .Where(c => c.tyres.Any(t => t.pressure < 1))
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                cars
                    .Where(c => c.cargo.cargoType == "flamable")
                    .Where(c => c.engine.power > 250)
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
        }
    }
}