using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    internal class Person
    {
        public string Name { get; set; }
        public Address address { get; set; }

        public Person(string name, Address address)
        {
            Name = name;
            this.address = address;
        }

        public void Display()
        {
            Console.WriteLine($"Address of {Name} is {address.HomeNumber} {address.Street}{address.City}"); 
        }
    }
}
