using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_Data
{
    class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tyre> tyres;
        
        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tyres)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tyres = tyres;
        }
    }
}
