using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TrafficLight
{
    private LightColor colorState;
    
    public TrafficLight(LightColor colorState)
    {
        this.colorState = colorState;
    }

    public void ChangeState()
    {
        this.colorState = (LightColor)(((int)this.colorState + 1) % Enum.GetNames(typeof(LightColor)).Length);
    }

    public override string ToString()
    {
        return this.colorState.ToString();
    }
}