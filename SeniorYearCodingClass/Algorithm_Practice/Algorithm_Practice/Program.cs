using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
            string path2 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";
            string path3 = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";

            List<string> file = new List<string>();

            using(StreamReader sr = new StreamReader(path1))
            {
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }

            for(int i = 0; i < file.Count; i++)
            {
                if(file[i].Contains("QUARTER"))
                {
                    Console.WriteLine("q");
                }
                if (file[i].Contains("DIME"))
                {
                    Console.WriteLine("d");
                }
                if (file[i].Contains("NICKEL"))
                {
                    Console.WriteLine("n");
                }
                if (file[i].Contains("PENNY"))
                {
                    Console.WriteLine("p");
                }
                if (file[i].Contains("HALFDOLLAR"))
                {
                    Console.WriteLine("hd");
                }
            }


                Console.ReadKey();
        }
    }
}
