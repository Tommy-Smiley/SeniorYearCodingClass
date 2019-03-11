using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Code";
            Console.WriteLine(result(test));
            Console.ReadKey();
        }
        static string result(string word)
        {
            string end = "";

            for (int i = 0; i < word.Length + 1; i++)
            {
                end += word.Substring(0, i);
            }
            return end;
        }
    }
}
