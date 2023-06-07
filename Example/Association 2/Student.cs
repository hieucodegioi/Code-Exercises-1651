using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_2
{
    internal class Student
    {
        public string firstName;
        public string lastName;
        public Teacher Teacher;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void Display()
        {
            Console.WriteLine($"Student name is {this.firstName} {this.lastName} and Teacher name is {this.Teacher}");

        }
    }
}
