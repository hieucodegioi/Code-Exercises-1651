using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_2
{
    internal class Teacher
    {
        public string firstName;
        public string lastName;
        public Student Student;

        public Teacher(string firstName, string lastName, Student student)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Student = student;
        }

        public void Display()
        {
            Console.WriteLine($"Teacher name is {this.firstName} {this.lastName} and Student name is {this.Student}");
        }
        public override string? ToString()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}
