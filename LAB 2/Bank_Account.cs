using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Bank_Account
    {
        public int Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public decimal Account_Balance;

        public void GetAccountDetails()
        {
            Console.Write("Account Number: ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.Write("Email: ");
            Email = Console.ReadLine() ?? string.Empty;

            Console.Write("User Name: ");
            User_Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Account Type: ");
            Account_Type = Console.ReadLine() ?? string.Empty;

            Console.Write("Account Balance: ");
            Account_Balance = Convert.ToDecimal(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Bank Account Details:");
            Console.WriteLine($"Account Number: {Account_No}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"User Name: {User_Name}");
            Console.WriteLine($"Account Type: {Account_Type}");
            Console.WriteLine($"Account Balance: {Account_Balance:N2}");
        }
    }
}
