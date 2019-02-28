using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueClass
{
    class Queue<T> : IEmptyable, IPrintable, ICountable where T : IComparable
    {
        List<T> holder = new List<T>();

        public Queue()
        {

        }

        public void enQueue(T val)
        {
            holder.Add(val);
        }
        
        public T deQueue()
        {
            if (holder.Count != 0)
            {
                T x = holder[0];
                holder.RemoveAt(0);
                return x;
            }
            else
            {
                return default(T);
            }
        }
        
        public T Peek()
        {
            if (holder.Count != 0)
            {
                return holder[0];
            }
            else
            {
                return default(T);
            }
        }
        
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.Write(holder[i] + ", ");
            }
        }

        public List<int> Search(T val)
        {
            List<int> positions = new List<int>();

            for (int i = 0; i < holder.Count; i++)
            {
                if (val.CompareTo(holder[i]) == 0)
                {
                    positions.Add(i);
                }
            }
            return positions;
        }

        public void Empty()
        {
            holder.Clear();
        }

        public int Count()
        {
            return holder.Count();
        }

    }
}