using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Indexrangeerror
    {
        public void  Indexerror() {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            try
            {
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException caught: Tried to access an index outside the array bounds.");
            }
        }
    }
}
