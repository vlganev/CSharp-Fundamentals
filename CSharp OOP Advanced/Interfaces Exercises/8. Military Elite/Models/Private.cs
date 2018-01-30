using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Private : Soldier, IPrivate
{
    private double salary;

    public Private(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
    {
        this.salary = salary;
    }

    public double Salary => this.salary;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder
            .Append(base.ToString())
            .Append($" Salary: {this.Salary:f2}");

        return builder.ToString().Trim();
    }
}
