using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Car : Automobile
    {
        protected string trunkType;

        public Car(float weight, float doors, string trunkType) : base(weight, doors)
        {
            this.trunkType = trunkType;
        }

        public override void noise()
        {
            base.noise();
            Console.WriteLine("ima car, ");
        }

        public override void printlist()
        {

        }
    }
}
