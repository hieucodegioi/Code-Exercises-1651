using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercises
{
    internal class Person
    {

        private string name;
        public virtual string Name
        {
            get { return name; }
            
            set 
            {
                if (value.Length < 3 )
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
            }

        }
        private int age;
        public virtual int Age
        {

            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("age must be positive!!");

                }
                else if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                     this.Name,
                                     this.Age));

                return stringBuilder.ToString();

            }
        }
    }
}
