using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Student
    {
        string enrollmentNo;
        string studentName;
        int semester;
        double cpi;
        double spi;

        public Student()
        {
            Console.WriteLine("------------------Enter Student Details-----------------------");

            Console.Write("Enter Enrollment Number: ");
            enrollmentNo = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Semester (1-8): ");
            semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter CPI (0.0 - 10.0): ");
            cpi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter SPI (0.0 - 10.0): ");
            spi = Convert.ToDouble(Console.ReadLine());

        }



        public void DisplayStudentDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Enrollment Number: {enrollmentNo}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"CPI: {cpi:F2}");
            Console.WriteLine($"SPI: {spi:F2}");

        }
    }
}
