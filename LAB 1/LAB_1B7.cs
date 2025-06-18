using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1B7
    {
        public void SimpleInterest()
        {
            Console.WriteLine("Enter the value of P ::: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of R ::: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of N ::: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = p * r * n / 100;
            Console.WriteLine("Your Simple Interest Is ::: " + i);
        }
    }
}
