using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        string[] telephones = Console.ReadLine().Split(new char[] { ' ' });
        string[] webSites = Console.ReadLine().Split(new char[] { ' ' });
        Smartphone sp = new Smartphone();

        for (int i = 0; i < telephones.Length; i++)
        {
            try
            {
                Console.WriteLine(sp.Call(telephones[i]));
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        for (int i = 0; i < webSites.Length; i++)
        {
            try
            {
                Console.WriteLine(sp.Browse(webSites[i]));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
