using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Robot : IIdentifiable
{
    private string name;
    private string id;

    public Robot(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }

    public string Name { get; private set; }
    public string Id { get; private set; }
}