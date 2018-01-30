using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IIdentifiable, IBirthDate
{
    private string name;
    private string age;
    private string id;
    private string birthDate;

    public Citizen(string name, string age, string id, string birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.BirthDate = birthDate;
    }

    public string Name { get; private set; }
    public string Age { get; private set; }
    public string Id { get; private set; }
    public string BirthDate { get; private set; }
}