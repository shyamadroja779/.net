using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class Zerodivideerror
    {
        public  void DIVISION()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b; // This will throw DivideByZeroException
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
