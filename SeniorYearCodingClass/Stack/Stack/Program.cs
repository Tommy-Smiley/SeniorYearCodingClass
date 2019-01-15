using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=0;
            stack mystack = new stack();

            do
            {
                Console.WriteLine("**********");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Quit");
                Console.WriteLine("**********");
                choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.WriteLine();
                    Console.Write("Enter a number to add: ");
                    int addnum = int.Parse(Console.ReadLine());
                    mystack.push(addnum);
                    Console.ReadKey();
                    Console.Clear();
                }
                if (choice == 2)
                {
                    Console.WriteLine();
                    int temp = mystack.pop();
                    if(temp == -1)
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        Console.WriteLine(temp);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                if (choice == 3)
                {
                    Console.WriteLine();
                    int temp = mystack.pop();
                    if (temp == -1)
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        Console.WriteLine(temp);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                if (choice == 4)
                {
                    Console.WriteLine();
                    mystack.print();
                    Console.ReadKey();
                    Console.Clear();
                }
                if (choice == 5)
                { 
                    Console.WriteLine();
                    Console.Write("Enter a value to search for: ");
                    int use = int.Parse(Console.ReadLine());
                    Console.WriteLine(mystack.search(use));
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (choice != 6);
        }
    }
}
