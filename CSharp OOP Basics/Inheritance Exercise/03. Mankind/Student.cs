using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if(value.Length < 5 || value.Length >10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                    .Append(Environment.NewLine)
                    .Append("Last Name: ").Append(this.LastName)
                    .Append(Environment.NewLine)
                    .Append("Faculty number: ").Append(this.FacultyNumber);

            return sb.ToString();
        }
    }
}
