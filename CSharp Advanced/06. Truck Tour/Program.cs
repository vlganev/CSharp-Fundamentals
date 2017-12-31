/*
Suppose there is a circle. There are N petrol pumps on that circle. Petrol pumps are numbered 0 to (N−1) (both inclusive). 
You have two pieces of information corresponding to each of the petrol pump: (1) the amount of petrol that particular petrol 
pump will give, and (2) the distance from that petrol pump to the next petrol pump.
Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at any of the petrol pumps. 
Calculate the first point from where the truck will be able to complete the circle. Consider that the truck will stop at 
each of the petrol pumps. The truck will move one kilometer for each liter of the petrol.
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class TruckTour
{
    static int entries;
    static Queue<int[]> pumps;

    public static void Main(string[] args)
    {

        entries = int.Parse(Console.ReadLine());
        pumps = new Queue<int[]>();

        for (int entry = 0; entry < entries; entry++)
            pumps.Enqueue(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

        for (int entry = 0; entry < entries; entry++)
        {
            if (IsSolution())
            {
                Console.WriteLine(entry);
                break;
            }
            int[] startingPump = pumps.Dequeue();
            pumps.Enqueue(startingPump);
        }

    }

    static bool IsSolution()
    {
        int tankFuel = 0;
        bool foundAnswer = true;

        for (int entry = 0; entry < entries; entry++)
        {
            int[] currPump = pumps.Dequeue();
            tankFuel += currPump[0] - currPump[1];
            if (tankFuel < 0)
                foundAnswer = false;
            pumps.Enqueue(currPump);
        }

        if (foundAnswer)
            return true;
        else
            return false;
    }
}