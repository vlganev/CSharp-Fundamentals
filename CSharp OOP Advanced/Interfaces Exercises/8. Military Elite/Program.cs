using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        List<ISoldier> soldiers = new List<ISoldier>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string position = tokens[0];
            string id = tokens[1];
            string firstName = tokens[2];
            string lastName = tokens[3];
            double salary;

            switch (position)
            {
                case "Private":
                    salary = double.Parse(tokens[4]);
                    Private privateSoldier = new Private(id, firstName, lastName, salary);
                    soldiers.Add(privateSoldier);
                    break;
                case "LeutenantGeneral":
                    salary = double.Parse(tokens[4]);
                    var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);
                    var privatesIds = tokens.Skip(5);
                    foreach (var privateId in privatesIds)
                    {
                        var priv = (Private)soldiers.FirstOrDefault(s => s.Id == privateId);
                        leutenantGeneral.Privates.Add(priv);
                    }
                    soldiers.Add(leutenantGeneral);
                    break;
                case "Engineer":
                    salary = double.Parse(tokens[4]);
                    var corps = tokens[5];
                    try
                    {
                        var engineer = new Engineer(id, firstName, lastName, salary, corps);
                        var repairs = tokens.Skip(6).ToList();
                        for (int i = 0; i < repairs.Count; i += 2)
                        {
                            var repair = new Repair(repairs[i], int.Parse(repairs[i + 1]));
                            engineer.Repairs.Add(repair);
                        }
                        soldiers.Add(engineer);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                case "Commando":
                    salary = double.Parse(tokens[4]);
                    corps = tokens[5];
                    try
                    {
                        var commando = new Commando(id, firstName, lastName, salary, corps);
                        var missions = tokens.Skip(6).ToList();
                        for (int i = 0; i < missions.Count; i += 2)
                        {
                            try
                            {
                                var mission = new Mission(missions[i], missions[i + 1]);
                                commando.Missions.Add(mission);
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                        soldiers.Add(commando);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;
                case "Spy":
                    var codeNumber = int.Parse(tokens[4]);
                    var spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(spy);
                    break;
                default:
                    break;
            }
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier.ToString());
        }
    }
}
