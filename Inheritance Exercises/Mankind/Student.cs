using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    internal class Student : Human
    {

        
        private string facultyNumber;

        public Student()
        {
            FirstName = "Duong";
            LastName = "hieu";
        }

        public Student(string facultyNumber,string firstName, string lastName) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                facultyNumber = value;
            }
        }


        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Faculty number: {FacultyNumber}");
        }
    }
}
