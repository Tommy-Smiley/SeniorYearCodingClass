using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBits
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            Console.WriteLine(bits(word));
            Console.ReadKey();
        }

        static string bits(string wurd)
        {
            string end = "";

            for (int i = 0; i < wurd.Length; i+=2)
            {
                end += wurd[i];
            }
            return end;
        }
    }
}
