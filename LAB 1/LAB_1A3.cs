using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class LAB_1A3
    {
        public void Intro()
        {
            Console.WriteLine("Enter Your Name Here: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Your Country Name Here: ");
            string Country = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {Name} from country {Country}");
        }

    }
}
