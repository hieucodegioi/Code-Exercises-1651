using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1651
{
    internal class Point
    {
        private int pointID;
        public int PointID
        {
            get { return pointID; }
            set { pointID = value; }
        }
        private double mathPoint;
        public double MathPoint
        {
            get { return mathPoint; }
            set { mathPoint = value; }
        }
        private double chemistryPoint;
        public double ChemistryPoint
        {
            get { return chemistryPoint; }
            set { chemistryPoint = value; }
        }
        private double physicsPoint;
        public double PhysicsPoint
        {
            get { return physicsPoint; }
            set
            {
                physicsPoint = value;
            }
        }
         
    }
}
