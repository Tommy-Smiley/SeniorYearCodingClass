using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Truck : Automobile
    {
        protected float bedsize;

        public Truck(float weight, float doors, float bedsize) : base(weight, doors)
        {
            this.bedsize = bedsize;
        }

        public override void noise()
        {
            base.noise();
            Console.WriteLine("ima truck ");
        }

        public override void printlist()
        {

        }
    }
}
