using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_lab
{
    internal class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;}
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value;}
        }
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (age < 0)
                    throw new ArgumentException("You must input value AGE > 0");
                age = value;
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string? ToString()
        {
            return firstName + " " + lastName + " is " + Age + " years old.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * (percentage / 100);
            }else
            {
                this.salary += this.salary * int(percentage / 200);
            }
        }
    }
}
