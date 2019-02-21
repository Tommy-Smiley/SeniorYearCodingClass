using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringtimes("Hi", 2));
            Console.ReadKey();
        }
        static string stringtimes(string word, int times)
        {
            string encode = "";
            for (int i = 0; i < times; i++)
            {
                encode += word;
            }
            return encode;
        }
    }
}
