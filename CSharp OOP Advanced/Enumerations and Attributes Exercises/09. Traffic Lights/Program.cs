using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        List<TrafficLight> allTrafficLights = new List<TrafficLight>();
        string[] inputSignal = Console.ReadLine().Split();
        int stateChangeCount = int.Parse(Console.ReadLine());
        foreach (var signal in inputSignal)
        {
            LightColor initialColorState = (LightColor)Enum.Parse(typeof(LightColor), signal);
            allTrafficLights.Add(new TrafficLight(initialColorState));
        }

        for (int i = 0; i < stateChangeCount; i++)
        {
            foreach (var trafficLight in allTrafficLights)
            {
                trafficLight.ChangeState();
            }
            Console.WriteLine(string.Join(" ", allTrafficLights));
        }
    }
}
