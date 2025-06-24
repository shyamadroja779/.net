using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class StackProgram
 {
      
            public void run()
            {
                Stack<int> st = new Stack<int>();
                int choice = 0;
                while (choice != -1)
                {
                    Console.WriteLine("Enter 1 to push: ");
                    Console.WriteLine("Enter 2 to pop: ");
                    Console.WriteLine("Enter 3 to peek: ");
                    Console.WriteLine("Enter 4 to check for contains: ");
                    Console.WriteLine("Enter 5 to Clear");
                    Console.WriteLine("Enter -1 to exit : ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter a number : ");
                            st.Push(int.Parse(Console.ReadLine()));
                            foreach (Object o in st)
                            {
                                Console.WriteLine(o.ToString());
                            }

                            break;
                        case 2:
                            Console.WriteLine(st.Pop() + " has been removed");
                            break;
                        case 3:
                            Console.WriteLine("Top ELement = " + st.Peek());
                            break;
                        case 4:
                            Console.Write("Enter the element you want to check : ");
                            int a = int.Parse(Console.ReadLine());
                            if (st.Contains(a))
                            {
                                Console.WriteLine("Stack contains " + a);
                            }
                            else
                            {
                                Console.WriteLine("Stack does not contain " + a);
                            }
                            break;
                        case 5:
                            st.Clear();
                            break;
                        case -1:
                            Console.WriteLine("Exiting the loop...");
                            return;
                    }
                }
            }
        }
    }

