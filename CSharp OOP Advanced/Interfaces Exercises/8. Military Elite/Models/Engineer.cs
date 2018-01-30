using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private IList<IRepair> repairs;

    public Engineer(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new List<IRepair>();
    }

    public IList<IRepair> Repairs => this.repairs;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder
            .AppendLine(base.ToString())
            .AppendLine("Repairs:");

        foreach (var repair in this.repairs)
        {
            builder.AppendLine($"  {repair}");
        }

        return builder.ToString().Trim();
    }
}
