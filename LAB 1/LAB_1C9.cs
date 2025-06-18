using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1C9
    {
        public void Swapping()
        {
            Console.WriteLine("Enter First Variable ::: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Variable ::: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entered Variables are :::: {x},{y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"After Swapping ::::: {x},{y}");
        }

    }
}
