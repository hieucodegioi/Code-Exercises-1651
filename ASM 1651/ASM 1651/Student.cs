using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    internal class Student : Person
    {
        List<Point> points = new List<Point>();
        private int studentID;
        public int StudentID
        {
            get { return studentID; }
            set
            {
                studentID = value;
            }
        }
        public List<Point> Points { get => points; set => points = value; }

        
        public Student(int studentID,string name, string email, string address, string phoneNumber) : this(studentID)
        {
        }
        public Student(int studentID)
        {
            StudentID = studentID;
        }
        public Student()
        {
        }
    }
}
