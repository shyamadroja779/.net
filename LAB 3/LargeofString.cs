using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class LargeofString
    {
        public void run() 
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine()!;

            string[] words = input.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = "";
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            Console.WriteLine("Longest word: " + longestWord);
        }
    }
}
