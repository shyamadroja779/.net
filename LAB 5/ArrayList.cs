using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class ArrayListExample 
    {
        public void run()
        {
            ArrayList studentName = new ArrayList(); 
            int choice = 0;
            while (choice != -1)
            {
                Console.WriteLine("Enter 1 to add a student : ");
                Console.WriteLine("Enter 2 to remove a student : ");
                Console.WriteLine("Enter 3 to remove range from student : ");
                Console.WriteLine("Enter 4 to clear the StudentName : ");
                Console.WriteLine("Enter -1 to exit : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name you want to add : ");
                        studentName.Add(Console.ReadLine());
                        foreach (Object o in studentName)
                        {
                            Console.WriteLine(o.ToString());
                        }
                        break;
                    case 2:
                        Console.Write("Enter name you want to remove : ");
                        studentName.Remove(Console.ReadLine());
                        foreach (Object o in studentName)
                        {
                            Console.WriteLine(o.ToString());
                        }
                        break;
                    case 3:
                        Console.Write("Enter index from which you want to remove : ");
                        int index = int.Parse(Console.ReadLine());
                        Console.Write("Enter no. of elements you want to remove : ");
                        int num = int.Parse(Console.ReadLine());
                        studentName.RemoveRange(index, num);
                        foreach (Object o in studentName)
                        {
                            Console.WriteLine(o.ToString());
                        }
                        break;
                    case 4:
                        studentName.Clear();
                        break;
                    case -1:
                        Console.WriteLine("Exiting the loop...");
                        return;
                }
            }
        }
    }
}