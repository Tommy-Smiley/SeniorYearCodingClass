using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class stack
    {
        List<int> hold = new List<int>();

        public stack()
        {

        }

        public void push(int val)
        {
            hold.Add(val);
        }

        public int pop()
        {
            if (hold.Count > 0)
            {
                int num = 0;
                num = hold[hold.Count - 1];
                hold.RemoveAt(hold.Count - 1);
                return num;
            }
            return -1;
        }

        public int peek()
        {
            if (hold.Count > 0)
            {
                return hold[hold.Count - 1];
            }
            return -1;
        }

        public int search(int val)
        {
            int count = 0;
            for(int i = hold.Count - 1; i > -1; i--)
            {
                if (hold[i] == val)
                {
                    return count;
                }
                count++;
            }
            return -1;
          
        }

        public void print()
        {
            for (int i = hold.Count - 1; i > -1; i--)
            {
                Console.WriteLine(hold[i]);
            }
        }
    }
}
