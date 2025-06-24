using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    interface Shape
    {
        double Circle(double radius);
        double Triangle(double @base, double height);
        double Square(double side);
    }

    class AreaCalculator : Shape
    {
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Triangle(double @base, double height)
        {
            return 0.5 * @base * height;
        }

        public double Square(double side)
        {
              return side * side;
        }
    }
}
