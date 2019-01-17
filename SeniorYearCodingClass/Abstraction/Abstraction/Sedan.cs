using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Sedan : Car
    {
        protected string engine;

        public Sedan(float weight, float doors, string trunkType, string engine) : base(weight, doors, trunkType)
        {
            this.engine = engine;
        }

        public override void noise()
        {
            base.noise();
            Console.WriteLine("a small car");
        }

        public override void printlist()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This car is a Sedan.");
            Console.WriteLine("This car is the smallest car at only " + weight + " pounds.");
            Console.WriteLine("This car had the smallest number of doors to cut weight and size with only " + doors + " doors.");
            Console.WriteLine("This car has a " + trunkType + " rotating trunk to fit on a small car.");
            Console.WriteLine("This car has only a " + engine + " engine made for small cars.");
            Console.WriteLine();
        }
    }
}
