using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    internal class StringMethod
    {
        public void run()
        {
            string text = "  Hello, World!  ";
            string another = "hello, world!";
            string[] words = { "Hello", "World", "CSharp" };

            // Length
            Console.WriteLine(text.Length);

            // Trim, TrimStart, TrimEnd
            Console.WriteLine(text.Trim());
            Console.WriteLine(text.TrimStart());
            Console.WriteLine(text.TrimEnd());

            // ToUpper, ToLower
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());

            // Substring
            Console.WriteLine(text.Substring(2, 5));

            // IndexOf, LastIndexOf
            Console.WriteLine(text.IndexOf('o'));
            Console.WriteLine(text.LastIndexOf('o'));

            // Replace
            Console.WriteLine(text.Replace("World", "C#"));

            // Contains
            Console.WriteLine(text.Contains("Hello"));

            // StartsWith, EndsWith
            Console.WriteLine(text.StartsWith("  Hello"));
            Console.WriteLine(text.EndsWith("  "));

            // Equals (case-sensitive and case-insensitive)
            Console.WriteLine(text.Equals(another));
            Console.WriteLine(text.Equals(another, StringComparison.OrdinalIgnoreCase));

            // Concat, Join
            Console.WriteLine(string.Concat(text, another));
            Console.WriteLine(string.Join("-", words));

            // Insert, Remove
            Console.WriteLine(text.Insert(2, "C# "));
            Console.WriteLine(text.Remove(2, 3));

            // PadLeft, PadRight
            Console.WriteLine(text.PadLeft(20, '*'));
            Console.WriteLine(text.PadRight(20, '*'));

            // Split
            var split = text.Split(',');
            foreach (var s in split)
                Console.WriteLine(s);

            // ToCharArray
            char[] chars = text.ToCharArray();
            foreach (var c in chars)
                Console.Write(c + " ");
            Console.WriteLine();

            // CopyTo
            char[] buffer = new char[5];
            text.CopyTo(2, buffer, 0, 5);
            Console.WriteLine(new string(buffer));

            // Format, Interpolation
            Console.WriteLine(string.Format("Value: {0}", 123));
            Console.WriteLine($"Interpolated: {text.Trim()}");

            // Compare, CompareOrdinal
            Console.WriteLine(string.Compare(text, another));
            Console.WriteLine(string.CompareOrdinal(text, another));

            // IsNullOrEmpty, IsNullOrWhiteSpace
            Console.WriteLine(string.IsNullOrEmpty(""));
            Console.WriteLine(string.IsNullOrWhiteSpace("   "));

            // Normalize, IsNormalized
            string norm = text.Normalize();
            Console.WriteLine(norm.IsNormalized());

            // GetHashCode
            Console.WriteLine(text.GetHashCode());

            // Clone
            object clone = text.Clone();
            Console.WriteLine(clone);

            // ToString
            Console.WriteLine(text.ToString());
        }
    }
}
