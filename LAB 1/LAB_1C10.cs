using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1C10
    {
        public void MaxOfThree()
        {
            Console.WriteLine("Enter First Digit ::: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Digit ::: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Digit ::: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int max = (x > y) ? ((x > z) ? x : z) : ((y > z) ? y : z);

            Console.WriteLine("Maximum Number is :::: " + max);
        }
    }
}

