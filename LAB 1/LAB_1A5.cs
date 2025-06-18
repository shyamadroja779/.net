using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1A5
    {
        public void AreaOfCircle()
        {
            Console.WriteLine("Enter the Radius Of Circle:::: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Area Of Circle Is:::::: " + (3.14 * r * r));
        }
        public void AreaOfSquare()
        {
            Console.WriteLine("Enter Side Of The Square::: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Area of Square is:::::: " + (s * s));
        }

        public void AreaOfRect()
        {
            Console.WriteLine("Enter Height Of Rectangle:: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width Of Rectangle:: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Area of rectangle is:: " + (h * w));
        }


    }
}
