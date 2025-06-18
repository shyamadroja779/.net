using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1B6
    {
        public void ConverterCtoF()
        {
            Console.WriteLine("Enter Celsius ::: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int f = (c * 9 / 5) + 32;
            Console.WriteLine("In Fahrenheit :: " + f);
        }
        public void ConverterFtoC()
        {
            Console.WriteLine("Enter Fahrenheit ::: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int c = (f - 32) * 5 / 9;
            Console.WriteLine("In Celsius :: " + c);
        }

    }
}
