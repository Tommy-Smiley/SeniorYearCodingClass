using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            List<int> l3 = new List<int>();
            List<int> l4 = new List<int>();
            List<int> l5 = new List<int>();

            //l3 = l1.Intersect(l2).ToList();

            //for (int i = 0; i < l3.Count; i++)
            //{
            //    Console.Write(l3[i] + ", ");
            //}

            //Console.WriteLine();

            //l4 = l1.Where(t => t >= 5 == true).ToList();

            //for (int i = 0; i < l4.Count; i++)
            //{
            //    Console.Write(l4[i] + ", ");
            //}

            //Console.ReadKey();

            //not LINQ

            int max = 0;

            max = l1[1];

            for(int i = 0; i < l1.Count; i++)
            {
                if(l1[i] > max)
                {
                    max = l1[i];
                }
            }

            Console.WriteLine(max);

            Console.ReadKey();

            //LINQ

            Console.WriteLine(l1.Max());

            Console.ReadKey();
        }
    }
}
