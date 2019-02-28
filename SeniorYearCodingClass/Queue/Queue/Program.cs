using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myStack = new Queue<int>();

            int input = 0;

            do
            {
                Console.WriteLine("**********");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Quit");
                Console.WriteLine("**********");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Write("Value: ");
                    myStack.enQueue(int.Parse(Console.ReadLine()));

                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == 2)
                {
                    int result = myStack.deQueue();
                    Console.WriteLine(result + " has been deQueued");
                    
                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == 3)
                {
                    Console.WriteLine(myStack.Peek() + " has been peeked");
                    
                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == 4)
                {
                    myStack.Print();

                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == 5)
                {
                    List<int> foundValues;

                    Console.Write("What values are you looking for: ");
                    foundValues = myStack.Search(int.Parse(Console.ReadLine()));

                    Console.Write("Located at position: ");

                    for (int i = 0; i < foundValues.Count; i++)
                    {
                        Console.WriteLine(foundValues[i]);
                    }

                    Console.ReadKey();
                    Console.Clear();
                }

            } while (input != 6);

        }
    }
}