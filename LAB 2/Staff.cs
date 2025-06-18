using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Staff
    {
        string Name;
        string Department;
        string Designation;
        int Experience;
        double Salary;


        public void GetStaffDetail()
        {
            Console.WriteLine("Enter Your Name Here: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Department Here: ");
            Department = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Designation Here: ");
            Designation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Experience Here: ");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Salary Here: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
        }

        public bool IsHOD()
        {
            return Designation.ToUpper() == "HOD";
        }

        public void DisplayStaffDetails()
        {
            if (IsHOD())
            {
                Console.WriteLine($"Name: {Name}, Salary:{Salary}");
            }

        }
    }
}
