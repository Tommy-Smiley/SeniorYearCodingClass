using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class SmallTruck : Truck
    {
        protected float load;

        public SmallTruck(float weight, float doors, float bedsize, float load) : base(weight, doors, bedsize)
        {
            this.load = load;
        }

        public override void noise()
        {
            base.noise();
            Console.WriteLine("a small truck");
        }

        public override void printlist()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This a small truck.");
            Console.WriteLine("This truck is small and weighs " + weight + " pounds.");
            Console.WriteLine("This truck is a samll truck with a small bed and only " + doors + " doors.");
            Console.WriteLine("This truck has a small " + bedsize + " foot bed optimized smaller payloads.");
            Console.WriteLine("This truck has a " + load + " pound payload for most things.");
            Console.WriteLine();
        }
    }
}
