using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class QueueProgram
    {
        public void run()
        {
            Queue<int> q = new Queue<int>();
            int choice = 0;
            while (choice != -1)
            {
                Console.WriteLine("Enter 1 to enqueue: ");
                Console.WriteLine("Enter 2 to dequeue: ");
                Console.WriteLine("Enter 3 to peek: ");
                Console.WriteLine("Enter 4 to check for contains: ");
                Console.WriteLine("Enter 5 to Clear");
                Console.WriteLine("Enter -1 to exit : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number : ");
                        q.Enqueue(int.Parse(Console.ReadLine()));
                        foreach (Object o in q)
                        {
                            Console.WriteLine(o.ToString());
                        }

                        break;
                    case 2:
                        Console.WriteLine(q.Dequeue() + " has been removed");
                        break;
                    case 3:
                        Console.WriteLine("Top ELement = " + q.Peek());
                        break;
                    case 4:
                        Console.Write("Enter the element you want to check : ");
                        int a = int.Parse(Console.ReadLine());
                        if (q.Contains(a))
                        {
                            Console.WriteLine("Queue contains " + a);
                        }
                        else
                        {
                            Console.WriteLine("Queue does not contain " + a);
                        }
                        break;
                    case 5:
                        q.Clear();
                        break;
                    case -1:
                        Console.WriteLine("Exiting the loop...");
                        return;
                }
            }
        }
    }
}