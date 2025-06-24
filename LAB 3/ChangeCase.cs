using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class ChangeCase
    {
        public void run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine()!;
            StringBuilder result = new StringBuilder(input.Length);
            foreach (char c in input)
            {
                if (char.IsLower(c))
                    result.Append(char.ToUpper(c));
                else if (char.IsUpper(c))
                    result.Append(char.ToLower(c));
                else
                    result.Append(c);
            }
            Console.WriteLine("Converted string: " + result.ToString());
        }
    }
}
