using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Hatchback : Car
    {
        protected string engine;

        public Hatchback(float weight, float doors, string trunkType, string engine) : base(weight, doors, trunkType)
        {
            this.engine = engine;
        }

        public override void noise()
        {
            base.noise();
            Console.WriteLine("a big car");
        }

        public override void printlist()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This car is a Hatchback.");
            Console.WriteLine("This car is the second smallest car at " + weight + " pounds.");
            Console.WriteLine("This car has more doors than the sedan with " + doors + " doors.");
            Console.WriteLine("This car has a " + trunkType + " trunk that fits on a bigger back end.");
            Console.WriteLine("This car has a " + engine + " engine made for hatchbacks.");
            Console.WriteLine();
        }
    }
}
