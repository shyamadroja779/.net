using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    internal class Areacal
    {
        public double Area(double side)
        {
            return side * side;
        }


        public double Area(double length, double width)
        {
            return length * width;
        }


        public double Area(float radius)
        {
            return Math.PI * radius * radius;
        }
    }

}
