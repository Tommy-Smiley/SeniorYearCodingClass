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
            int input = 0;

            List<string> file = new List<string>();

            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
            string path2 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";
            string path3 = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";
            string path4 = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in_.txt";
            string path5 = AppDomain.CurrentDomain.BaseDirectory + @"Prob05.in_.txt";

            do
            {
                Console.WriteLine("************");
                Console.WriteLine("1. Problem 1");
                Console.WriteLine("2. Problem 2");
                Console.WriteLine("3. Problem 3");
                Console.WriteLine("4. Problem 4");
                Console.WriteLine("5. Problem 5");
                Console.WriteLine("6. Quit");
                Console.WriteLine("************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    float total = 0f;

                    using (StreamReader sr = new StreamReader(path1))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            file.Add(line);
                        }
                    }

                    for (int i = 0; i < file.Count; i++)
                    {
                        if (file[i].Contains("QUARTER"))
                        {
                            string s = file[i];
                            s = s.Substring(8);
                            total += float.Parse(s) * .25f;
                        }
                        if (file[i].Contains("DIME"))
                        {
                            string s = file[i];
                            s = s.Substring(5);
                            total += float.Parse(s) * .10f;
                        }
                        if (file[i].Contains("NICKEL"))
                        {
                            string s = file[i];
                            s = s.Substring(7);
                            total += float.Parse(s) * .05f;
                        }
                        if (file[i].Contains("PENNY"))
                        {
                            string s = file[i];
                            s = s.Substring(6);
                            total += float.Parse(s) * .01f;
                        }
                        if (file[i].Contains("HALFDOLLAR"))
                        {
                            string s = file[i];
                            s = s.Substring(11);
                            total += float.Parse(s) * .50f;
                        }
                    }
                    Console.WriteLine("$" + total.ToString("0.00"));
                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == 2)
                {
                    List<string> nums = new List<string>();

                    using (StreamReader sr = new StreamReader(path2))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            
                            nums = line.Split(' ').ToList();
                            
                        }
                        
                    }
                    for(int i =0; i < nums.Count; i++)
                    {
                        Console.WriteLine(nums[i]);
                    }
                    
                    
                }

                if (input == 3)
                {

                }

                if (input == 4)
                {

                }

                if (input == 5)
                {

                }

            } while (input != 6);

        }
    }
}
