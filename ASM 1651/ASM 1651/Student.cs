using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    internal class Student : Person
    {
        public List<Point> Points { get; set; }

        public Student(int id, string name, DateTime dateOfBirth) : base()
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Points = new List<Point>();
        }

        public void AddPoint(string subject, double value)
        {
            Point point = new Point(subject, value);
            Points.Add(point);
        }

        public override string ToString()
        {
            string pointsString = "";
            foreach (Point point in Points)
            {
                pointsString += point.ToString() + ", ";
            }
            pointsString = pointsString.TrimEnd(',', ' ');

            return $"ID: {Id}, Name: {Name}, Date of Birth: {DateOfBirth.ToShortDateString()}, Points: {pointsString}";
        }
    }
}
