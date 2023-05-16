using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Exercises
{
    internal class Person
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private int age;    
        public int Age
        {
            set { age = value; }    

            get { return age; }

        }
        Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        Person( int age)
        {

            if (this.age % 2 == 0)
            {
                this.age = age;
            }
            this.name = "No name";
            
        }
        Person(int age, string name)
        {
            this.name=name;
            this.age = age;
        }
        public override string ToString()
        {
            return name + " " + age;
        }
    }
}
