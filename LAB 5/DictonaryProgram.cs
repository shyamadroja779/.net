using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class DictonaryProgram
    { 
       
       
            public void run()
            {
                Dictionary<int, string> d = new Dictionary<int, string>();
                int choice = 0, key = -1;
                string value = "";
                while (choice != -1)
                {
                    Console.WriteLine("Enter 1 to add : ");
                    Console.WriteLine("Enter 2 to remove : ");
                    Console.WriteLine("Enter 3 for ContainsKey : ");
                    Console.WriteLine("Enter 4 for ContainsValue : ");
                    Console.WriteLine("Enter 5 to clear : ");
                    Console.WriteLine("Enter -1 to exit : ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter key : ");
                            key = int.Parse(Console.ReadLine());
                            Console.Write("Enter value : ");
                            value = Console.ReadLine();
                            d.Add(key, value);
                            foreach (Object o in d)
                            {
                                Console.WriteLine(o.ToString());
                            }

                            break;
                        case 2:
                            Console.Write("Enter key you want to remove : ");
                            key = int.Parse(Console.ReadLine());
                            d.Remove(key);
                            Console.WriteLine("Key removed = " + key);
                            break;
                        case 3:
                            Console.Write("Enter key to check : ");
                            key = int.Parse(Console.ReadLine());
                            if (d.ContainsKey(key))
                            {
                                Console.WriteLine("Dictionary contains " + key);
                            }
                            else
                            {
                                Console.WriteLine("Dictionary does not contain " + key);
                            }
                            break;
                        case 4:
                            Console.Write("Enter value value to check : ");
                            value = Console.ReadLine();
                            if (d.ContainsValue(value))
                            {
                                Console.WriteLine("Dictionary contains " + value);
                            }
                            else
                            {
                                Console.WriteLine("Dictionary does not contain " + value);
                            }
                            break;
                        case 5:
                            d.Clear();
                            break;
                        case -1:
                            Console.WriteLine("Exiting the loop...");
                            return;
                    }
                }
            }
        }
    }


