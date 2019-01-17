using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class BigTruck : Truck
    {
        protected float load;

        public BigTruck(float weight, float doors, float bedsize, float load) : base(weight, doors, bedsize)
        {
            this.load = load;
        }
        public override void noise()
        {
            base.noise();
            Console.WriteLine("a big truck");
        }

        public override void printlist()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This a big truck.");
            Console.WriteLine("This truck biggest and heaviest truck at " + weight + " pounds.");
            Console.WriteLine("This truck is a big truck with a full bed and " + doors + " doors.");
            Console.WriteLine("This truck has a large " + bedsize + " foot bed optimized for large trucks and large payloads.");
            Console.WriteLine("This truck has a " + load + " pound payload for some real heavy things.");
            Console.WriteLine();
        }
    }
}
