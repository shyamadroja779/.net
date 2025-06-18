using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Account_Details
    {
            public string accountNumber;
            public string accountHolderName;
            public double principalAmount;
            public int timeInYears;
            public double rateOfInterest;

            public Account_Details()
            {
                Console.WriteLine("Enter Account Details:");
                Console.WriteLine("--------------------");

                Console.Write("Enter Account Number: ");
                accountNumber = Console.ReadLine();

                Console.Write("Enter Account Holder Name: ");
                accountHolderName = Console.ReadLine();

                Console.Write("Enter Principal Amount: ");
                principalAmount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Time Period (in years): ");
                timeInYears = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Rate of Interest (in %): ");
                rateOfInterest = Convert.ToDouble(Console.ReadLine());

            }

            public virtual void DisplayAccountDetails()
            {
                Console.WriteLine("\nAccount Details:");
                Console.WriteLine("---------------");
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Account Holder: {accountHolderName}");
                Console.WriteLine($"Principal Amount:{principalAmount:C}");
                Console.WriteLine($"Time Period: {timeInYears} years");
                Console.WriteLine($"Rate of Interest: {rateOfInterest}%");
            }
        }

         class Interest : Account_Details
        {
            private double totalInterest;
            private double totalAmount;

            public Interest() : base()
            {
                CalculateInterest();
            }

            public void CalculateInterest()
            {
                totalInterest = (principalAmount * timeInYears * rateOfInterest) / 100;
                totalAmount = principalAmount + totalInterest;
            }

            public override void DisplayAccountDetails()
            {
                base.DisplayAccountDetails();

                Console.WriteLine("\nInterest Details:");
                Console.WriteLine("----------------");
                Console.WriteLine($"Total Interest: {totalInterest}");
                Console.WriteLine($"Total Amount: {totalAmount}");
            }
        }
}
