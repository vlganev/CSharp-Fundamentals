using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog("Reks", "meso");
        Animal cat = new Cat("Maca", "zelenchuci");

        var listOfAnimals = new List<Animal>();
        listOfAnimals.Add(dog);
        listOfAnimals.Add(cat);

        Print(listOfAnimals);
    }

    public static void Print(List<Animal> animals)
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ExplainMyself());
        }
    }
}
