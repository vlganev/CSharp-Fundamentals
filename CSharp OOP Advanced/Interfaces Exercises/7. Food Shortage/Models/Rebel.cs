using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rebel : IBuyer
{
    private string name;
    private string age;
    private string group;
    private int food = 0;

    public Rebel(string name, string age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }

    public string Name { get; private set; }
    public int Food { get; private set; }
    public string Age { get; private set; }
    public string Group { get; private set; }

    public void BuyFood()
    {
        this.Food += 5;
    }
}
