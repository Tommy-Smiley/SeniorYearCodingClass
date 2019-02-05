using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class QueueGeneric<T> : IEmptyable, IPrintale, ICountable
    {
        List<T> queue = new List<T>();

        public QueueGeneric() {}

        public void Enqueue (T val)
        {
            queue.Insert(0, val);
        }

        public T Dequeue()
        {
            T temp = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return temp;
        }

        public T Peek()
        {
            return queue[queue.Count - 1];
        }

        public void empty()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }

        public void count()
        {
            throw new NotImplementedException();
        }

        int ICountable.count()
        {
            throw new NotImplementedException();
        }
    }

}
