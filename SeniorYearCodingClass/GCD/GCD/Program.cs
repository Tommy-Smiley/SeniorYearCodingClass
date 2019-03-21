using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(gcd(num1,num2));
            Console.ReadKey();
        }

        static int gcd(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            else if (b == 0)
            {
                return a;
            }

            else
            {
                return gcd(b, a % b);
            }

        }

    }
}
