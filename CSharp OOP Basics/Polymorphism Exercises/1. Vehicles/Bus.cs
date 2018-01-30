using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {

    }

    protected override double FuelQuantity {
        set
        {
            if (value > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
        }
    }

    public override string Drive(double distance, bool IsAcOn)
    {
        if(IsAcOn)
        {
            this.FuelConsumption = this.FuelConsumption + 1.4;
        }
        return base.Drive(distance, true);
    }
}
