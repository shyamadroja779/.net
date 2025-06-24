using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Evennoerroe
    {
        public void run() {
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            try
            {
                if (number % 2 != 0)
                    throw new Exception("The number is not even.");
                Console.WriteLine("The number is even.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
