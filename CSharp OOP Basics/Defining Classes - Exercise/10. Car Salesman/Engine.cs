using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.displacement = 0;
            this.efficiency = "n/a";
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Model { get { return this.model; } }

        public override string ToString()
        {
            var result = $"  {this.model}:";
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, $"    Power: {this.power}");
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.displacement == 0 ? "  Displacement: n/a" : $"    Displacement: {this.displacement}");
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, $"    Efficiency: {this.efficiency}");
            result = string.Concat(result, Environment.NewLine);

            return result;
        }
    }
}
