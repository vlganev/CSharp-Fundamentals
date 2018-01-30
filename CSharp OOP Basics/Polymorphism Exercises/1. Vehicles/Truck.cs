using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, (fuelConsumption + 1.6), tankCapacity)
    {

    }

    public override void Refuel(double fuel)
    {
        fuel *= 0.95;
        base.Refuel(fuel);
    }   
}
