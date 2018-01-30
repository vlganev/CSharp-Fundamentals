using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pet : IBirthDate
{
    private string name;
    private string birthdate;

    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.BirthDate = birthdate;
    }

    public string Name { get; private set; }
    public string BirthDate { get; private set; }
}
