using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1B8
    {
        public void SimpleCalc()
        {
            Console.WriteLine("Enter First Number :::");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number :::");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition of two numbers is ::: " + (x + y));
            Console.WriteLine("Subtraction of two numbers is ::: " + (x - y));
            Console.WriteLine("Multiplication of two numbers is ::: " + (x * y));
            Console.WriteLine("Division of two numbers is ::: " + (x / y));


        }

    }
}
