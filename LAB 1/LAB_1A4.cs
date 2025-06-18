using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1A4
    {
        public void Area()
        {
            Console.WriteLine("Enter Height Here: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your widht Here: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Size of area is ::: " + (h * w));
        }
    }
}
