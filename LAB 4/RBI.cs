using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    internal class RBI
    {
       public void calculateInterest(double principal, double rate, int time)
        {
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Interest: " + interest);
        }
        public class HDFC : RBI
        {
            public void calculateInterest(double principal, double rate, int time)
            {
                double interest = (principal * rate * time) / 100;
                Console.WriteLine("Interest from HDFC: " + interest);
            }
        }
        public class SBI : RBI
        {
            public void calculateInterest(double principal, double rate, int time)
            {
                double interest = (principal * rate * time) / 100;
                Console.WriteLine("Interest from SBI: " + interest);
            }
        }
        public class ICICI : RBI
        {
            public void calculateInterest(double principal, double rate, int time)
            {
                double interest = (principal * rate * time) / 100;
                Console.WriteLine("Interest from ICICI: " + interest);
            }
        }
  
    }
}
