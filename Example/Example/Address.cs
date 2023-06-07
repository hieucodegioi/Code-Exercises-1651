using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    internal class Address
    {
        public string HomeNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Address(string homenumber, string street, string city)
        {
            HomeNumber = homenumber;
            Street = street;    
            City = city;
        }
    }
}
