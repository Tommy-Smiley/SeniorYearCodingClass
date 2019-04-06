using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Queue<T>
    {

        List<int> holder = new List<int>();
        List<T> queue = new List<T>();

        public int Count { get { return queue.Count; } }

        static int timesEnqueued = 0;
        static int timesDequeued = 0;
        static int maxAmount = 0;

        public Queue()
        {

        }

        public void Enqueue(T value)
        {
            queue.Add(value);
            timesEnqueued++;
            if (maxAmount < queue.Count)
                maxAmount = queue.Count;
        }

        public T Dequeue()
        {
            timesDequeued++;
            T retVal = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return retVal;
        }

        public T Peek()
        {
            return queue[queue.Count - 1];
        }

        public T Pop()
        {
            T temp = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return temp;
        }

        public void Push(T val)
        {
            queue.Add(val);
        }
    }
}