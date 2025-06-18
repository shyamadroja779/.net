using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Salary
    {
        public decimal Basic;
        public decimal TA;
        public decimal DA;
        public decimal HRA;

        public Salary(decimal basic, decimal ta, decimal da = 2000, decimal hra = 3000)
        {
            Basic = basic;
            TA = ta;
            DA = da;
            HRA = hra;
        }

        public decimal CalculateTotalSalary()
        {
            return Basic + TA + DA + HRA;
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Basic: {Basic:N2}");
            Console.WriteLine($"TA: {TA:N2}");
            Console.WriteLine($"DA: {DA:N2}");
            Console.WriteLine($"HRA: {HRA:N2}");
            Console.WriteLine($"Total Salary: {CalculateTotalSalary():N2}");
        }

    }
}
