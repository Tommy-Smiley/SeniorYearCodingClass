using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CyberBoizProblem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> file = new List<string>();
            List<int> nums1 = new List<int>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                        file.Add(line);
                }

            }
            nums1[0] = int.Parse(file[0].Substring(0, 1));
            

            //print
            for (int i = 0; i < file.Count; i++)
            {
                Console.WriteLine(file[i]);
            }
            Console.WriteLine(nums1[0]);
            Console.ReadKey();
        }
    }
}
