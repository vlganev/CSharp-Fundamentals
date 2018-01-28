using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            double[] param = new double[3];
            for (int i = 0; i < 3; i++)
            {
                param[i] = double.Parse(Console.ReadLine()); ;
            }
            var box = new Box(param[0], param[1], param[2]);
            double surfaceArea = box.GetSurfaceArea();
            double lateralSurfaceArea = box.GetLateralSurfaceArea();
            double volume = box.GetVolume();
            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
            Console.WriteLine($"Volume - {volume:f2}");
        }
    }
}
