using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Candidate
    {
        
        int Id;
        string Name;
        int Age;
        string Height;
        int Weight;

        public void GetDetail()
        {
            Console.WriteLine("Enter Your Id Here: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name Here: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Age Here: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Height Here: ");
            Height = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Weight Here: ");
            Weight = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public void DisplayCandidate()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Weight: " + Weight);

        }

    }
}
