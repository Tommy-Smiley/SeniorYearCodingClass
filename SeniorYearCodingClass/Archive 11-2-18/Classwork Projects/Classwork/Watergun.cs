using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{

    class Watergun
    {
        float cap = 1;
        bool isWet = false;
        Random rand = new Random();

        public Watergun()
        {

        }
        public bool Shoot(float amount)
        {
            if (cap > 0)
            {
                cap -= amount;
                float perchance = (amount * .2f) + .2f;
                if (rand.NextDouble() < perchance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("You are empty");
                return false;
            }
        }
        public void refill()
        {
            cap += .25f;
        }
    }
}
