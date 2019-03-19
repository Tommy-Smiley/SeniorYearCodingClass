using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 17;

            Console.WriteLine(CheckforPrime(test));
            Console.ReadKey();
        }

        static bool CheckforPrime(int n, int divisor = 2)
        {
            if (n % divisor == 0)
            {
                return false;
            }
            if (divisor == n - 1)
            {
                return true;
            }

            return CheckforPrime(n, divisor + 1);
        }
    }
}
