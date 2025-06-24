using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    internal class Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Hospital Name:CIVIL " );
            Console.WriteLine("Location:MORBI " );
            Console.WriteLine("Capacity:1000 " );
        }
    }
    class Apollo : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Hospital Name:APOLLO " );
            Console.WriteLine("Location:MUMBAI " );
            Console.WriteLine("Capacity:2000 " );
        }
    }
    class Wockhardt : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("Hospital Name:WOCKHARDT " );
            Console.WriteLine("Location:MUMBAI " );
            Console.WriteLine("Capacity:1500 " );
        }
    }
     class Gokul_Superspeciality : Hospital
    {
      public void HospitalDetails()
        {
            Console.WriteLine("Hospital Name:GOKUL SUPERSPECIALITY " );
            Console.WriteLine("Location:AHMEDABAD " );
            Console.WriteLine("Capacity:500 " );
        }
    }
}
