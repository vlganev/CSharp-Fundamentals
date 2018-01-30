using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Repair : IRepair
{
    private string partName;
    private int workedHours;

    public Repair(string partName, int workedHours)
    {
        this.partName = partName;
        this.workedHours = workedHours;
    }

    public string PartName => this.partName;

    public int WorkedHours => this.workedHours;

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.WorkedHours}";
    }
}
