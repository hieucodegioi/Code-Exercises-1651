using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    internal class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string email; 
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        public Person()
        {
        }

        public Person(string name, string email, string address, string phoneNumber)
        {
            Name = name;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
