using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Person>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(' ');
                students.Add(new Person(tokens[0] + " " + tokens[1], int.Parse(tokens[2])));
                input = Console.ReadLine();
            }
            var grouped = students
                .GroupBy(pr => pr.Group)
                .OrderBy(gr => gr.Key);
            foreach (var group in grouped)
            {
                Console.Write(group.Key + " - ");
                foreach (var person in group)
                {
                    Console.WriteLine(person.Name);
                }
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }

        public Person(string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }
    }
}
