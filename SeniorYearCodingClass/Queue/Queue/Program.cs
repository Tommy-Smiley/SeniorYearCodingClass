using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Currencies.Enqueue(new Currencies(rand.Next(0,100), rand.Next(0, 100), rand.Next(0, 100)));
            }
        }
    }
}
