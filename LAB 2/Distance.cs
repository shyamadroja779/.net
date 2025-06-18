using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Distance
    {
        public double dist1;
        public double dist2;
        public double dist3;

        public Distance(double d1, double d2)
        {
            dist1 = d1;
            dist2 = d2;
            dist3 = 0;
        }

        public void AddDistances()
        {
            dist3 = dist1 + dist2;
        }

        public void DisplayAddition()
        {
            Console.WriteLine($"Addition of distances: {dist3:N2}");
        }
    }
}
