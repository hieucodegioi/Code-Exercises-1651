using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_3
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }

        public Department(string name)
        {
            Name = name;
            Rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }
}
