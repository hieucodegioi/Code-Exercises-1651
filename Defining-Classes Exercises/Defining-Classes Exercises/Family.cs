using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Exercises
{
    internal class Family
    {
        private List<Family> families;  
        public Family() 
        {
            families = new List<Family>();
        }
        public void AddMember(Person member)
        {
            families.Add(member); 
        }
    }
}
