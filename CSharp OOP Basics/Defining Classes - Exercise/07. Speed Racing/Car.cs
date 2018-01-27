using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Racing
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private double totalKilometers;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionFor1km = fuelConsumptionFor1km;
            this.totalKilometers = 0;
        }

        public void Drive(int kilometers)
        {
            double fuel = kilometers * this.fuelConsumptionFor1km;
            if (fuel > this.fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.totalKilometers += kilometers;
                this.fuelAmount -= fuel;
            }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionFor1km
        {
            get { return this.fuelConsumptionFor1km; }
            set { this.fuelConsumptionFor1km = value; }
        }

        public double TotalKilometers
        {
            get { return this.totalKilometers; }
            set { this.totalKilometers = value; }
        }
    }
}
