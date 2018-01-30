using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    protected virtual double TankCapacity
    {
        get { return tankCapacity; }
        set { tankCapacity = value; }
    }

    protected double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }


    protected virtual double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    public virtual void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += fuel;
    }

    public virtual string Drive(double distance, bool IsAcOn)
    {
        double currConsumption = distance * this.FuelConsumption;
        if (currConsumption > this.FuelQuantity)
        {
            return $"{this.GetType().Name} needs refueling";
        }
        else
        {
            this.FuelQuantity -= currConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }
    }

    public virtual string Drive(double distance) 
    {
        return this.Drive(distance, true);
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
    }
}
