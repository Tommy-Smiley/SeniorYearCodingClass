using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Currencies : IComparable<Currencies>, IPrintale
    {
        int goldcount = 0;
        int silvercount = 0;
        int coppercount = 0;

        public Currencies(int goldcount, int silvercount, int coppercount)
        {
            this.goldcount = goldcount;
            this.silvercount = silvercount;
            this.coppercount = coppercount;
        }

        public int CompareTo(Currencies other)
        {
            if (other == null) return 1;
            int total = goldcount * 1000 + silvercount * 100 + coppercount;
            int otherTotal = other.goldcount * 10000 + other.silvercount * 100 + other.coppercount;
            return total > otherTotal ? 1 : total < otherTotal ? -1 : 0;
        }

        public void print()
        {
            Console.WriteLine("You have " + goldcount + " gold, " + silvercount + " silver, and " + coppercount + " copper coins.");
        }
    }
}
