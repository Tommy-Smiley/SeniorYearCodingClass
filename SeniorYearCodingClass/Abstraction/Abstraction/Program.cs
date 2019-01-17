using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Automobile> all = new List<Automobile>();

            all.Add(new Sedan(2000,2,"small","4 cylinder"));
            all.Add(new Hatchback(2500,4,"big","6 cylinder"));
            all.Add(new BigTruck(4000,4,10,2500));
            all.Add(new SmallTruck(3000,2,6,1500));

            for(int i = 0; i < all.Count; i++)
            {
                all[i].printlist();
            }
            Console.ReadKey();
        }
    }
}
