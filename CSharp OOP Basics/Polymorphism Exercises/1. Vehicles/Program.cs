using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        string[] tokensCar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double carFuelQuantity = double.Parse(tokensCar[1]);
        double carFuelConsumption = double.Parse(tokensCar[2]);
        double carTankCapacity = double.Parse(tokensCar[3]);
        Vehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

        string[] tokensTruck = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double truckFuelQuantity = double.Parse(tokensTruck[1]);
        double truckFuelConsumption = double.Parse(tokensTruck[2]);
        double truckTankCapacity = double.Parse(tokensTruck[2]);
        Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

        string[] tokensBus = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double BusFuelQuantity = double.Parse(tokensTruck[1]);
        double BusFuelConsumption = double.Parse(tokensTruck[2]);
        double BusTankCapacity = double.Parse(tokensTruck[3]);
        Vehicle bus = new Bus(BusFuelQuantity, BusFuelConsumption, BusTankCapacity);

        int commandCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandCount; i++)
        {
            try
            {
                string[] tokensCommand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokensCommand[0] == "Drive")
                {
                    if (tokensCommand[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(tokensCommand[2])));
                    }
                    else if(tokensCommand[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(tokensCommand[2])));
                    }
                    else
                    {
                        Console.WriteLine(bus.Drive(double.Parse(tokensCommand[2])));
                    }
                }
                else if (tokensCommand[0] == "Refuel")
                {
                    if (tokensCommand[1] == "Car")
                    {
                        car.Refuel(double.Parse(tokensCommand[2]));
                    }
                    else if (tokensCommand[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(tokensCommand[2]));
                    }
                    else
                    {
                        bus.Refuel(double.Parse(tokensCommand[2]));
                    }
                }
                else if (tokensCommand[0] == "DriveEmpty")
                {
                    Console.WriteLine(bus.Drive(double.Parse(tokensCommand[2]), false));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}