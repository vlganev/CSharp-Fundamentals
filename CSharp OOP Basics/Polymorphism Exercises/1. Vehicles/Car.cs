using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, (fuelConsumption + 0.9), tankCapacity)
    {

    }


    protected override double FuelQuantity
    {
        set
        {
            if (value > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
        }
    }
}