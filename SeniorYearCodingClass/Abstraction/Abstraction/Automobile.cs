using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Automobile
    {
        protected float weight;
        protected float doors;
        protected bool hasBed;

        public Automobile(float weight, float doors)
        {
            this.weight = weight;
            this.doors = doors;
            this.hasBed = hasBed;
        }

        public virtual void noise()
        {
            Console.Write("VROOOOOM ");
        }

        public abstract void printlist();
    }
}
