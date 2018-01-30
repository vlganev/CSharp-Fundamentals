using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ferrari : ICar
{
    private string model;
    private string driver;

    public Ferrari(string model, string driver)
    {
        this.Model = model;
        this.Driver = driver;
    }

    public string Model
    {
        get { return this.model; }
        private set { this.model = value; }
    }

    public string Driver
    {
        get { return this.driver; }
        private set { this.driver = value; }
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string UseGas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder
            .Append($"{this.model}/{this.UseBrakes()}/{this.UseGas()}/{this.driver}");
        return builder.ToString().Trim();
    }
}
