using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opinion_Poll
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
            :this()
        {
            this.age = age;
        }

        public Person(string name, int age)
            : this()
        {
            this.age = age;
            this.name = name;
        }
    }
}
