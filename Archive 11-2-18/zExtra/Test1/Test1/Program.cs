using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static int a = 5;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Number:");
            int num = int.Parse(Console.ReadLine());
            
            m1(num);
            Console.ReadKey();
        }
        static int m2()
        {
            a = 10;
            return a;
        }

        static void m1(int lol)
        {
            Console.WriteLine(lol*2*m2());
            if (lol == 5)
            {
                for(int i = 0; i < 5; i++)
                {
                    m1(lol);
                    lol++;
                }
                
            }
        }
    }
}
