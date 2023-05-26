using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    internal class School
    {
        List<Student> Students = new List<Student>();
        List<Point> points = new List<Point>();
        private int schoolID;
        public int SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }
        public List<Point> Points { get => points; set => points = value; }
        public School(int schoolID)
        {
            SchoolID = schoolID;
        }
        public School()
        {
        }
    }
}
