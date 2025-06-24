using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class HashProgram
    {
        public void run()
        {
            Hashtable ht = new Hashtable();
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
                        ht.Add(key, value);
                        foreach (DictionaryEntry entry in ht)
                        {
                            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
                        }

                        break;
                    case 2:
                        Console.Write("Enter key you want to remove : ");
                        key = int.Parse(Console.ReadLine());
                        ht.Remove(key);
                        Console.WriteLine("Key removed = " + key);
                        break;
                    case 3:
                        Console.Write("Enter key to check : ");
                        key = int.Parse(Console.ReadLine());
                        if (ht.ContainsKey(key))
                        {
                            Console.WriteLine("Hashtable contains " + key);
                        }
                        else
                        {
                            Console.WriteLine("Hashtable does not contain " + key);
                        }
                        break;
                    case 4:
                        Console.Write("Enter value value to check : ");
                        value = Console.ReadLine();
                        if (ht.ContainsValue(value))
                        {
                            Console.WriteLine("HashTable contains " + value);
                        }
                        else
                        {
                            Console.WriteLine("HashTable does not contain " + value);
                        }
                        break;
                    case 5:
                        ht.Clear();
                        break;
                    case -1:
                        Console.WriteLine("Exiting the loop...");
                        return;
                }
            }
        }
    }
}
