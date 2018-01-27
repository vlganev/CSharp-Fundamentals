using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = 0;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }

        public override string ToString()
        {
            var result = $"{this.model}:";
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.engine.ToString());
            result = string.Concat(result, this.weight == 0 ? "  Weight: n/a" : $"  Weight: {this.weight}");
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, $"  Color: {this.color}");
            result = string.Concat(result, Environment.NewLine);

            return result;
        }
    }
}

