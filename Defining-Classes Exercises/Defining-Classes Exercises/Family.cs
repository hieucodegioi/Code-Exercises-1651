using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Exercises
{
    internal class Family
    {
        private List<Person> families;  
        public Family() 
        {
            families = new List<Person>();
        }
        public void AddMember(Person member)
        {
            families.Add(member); 
        }
        public Person GetOldestMember()
        {
            Person oldestPerson = null;
            int maxAge = int.MinValue;

            foreach (Person person in families)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldestPerson = person;
                }
            }

            return oldestPerson;
        }
    }
}
