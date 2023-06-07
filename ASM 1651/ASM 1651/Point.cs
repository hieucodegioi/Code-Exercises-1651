using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    internal class Point
    {
        public string Subject { get; set; }
        public double Value { get; set; }

        public Point(string subject, double value)
        {
            Subject = subject;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Subject}: {Value}";
        }
    }
}
