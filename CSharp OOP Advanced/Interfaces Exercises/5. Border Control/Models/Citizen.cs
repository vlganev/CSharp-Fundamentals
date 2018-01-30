using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IIdentifiable
{
    private string name;
    private string age;
    private string id;

    public Citizen(string name, string age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    public string Name { get; private set; }
    public string Age { get; private set; }
    public string Id { get; private set; }
}