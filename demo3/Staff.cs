using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class Staff
    {
        public string Name;
        public string department;
        public int salary;
        public string designation;
        public int experience;


        public void getdetails()
        {
            Console.WriteLine("Enter the name of the staff member:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the department of the staff member:");
            department = Console.ReadLine();
            Console.WriteLine("Enter the salary of the staff member:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the designation of the staff member:");
            designation = Console.ReadLine();
            Console.WriteLine("Enter the experience of the staff member in years:");
            experience = Convert.ToInt32(Console.ReadLine());
        }
        public void displaydetails()
        {
            Console.WriteLine("Staff Member Details:");
            Console.WriteLine($"Name: {Name}");
            //Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: {salary}");
            //Console.WriteLine($"Designation: {designation}");
            //Console.WriteLine($"Experience: {experience} years");

        }
    }
}
