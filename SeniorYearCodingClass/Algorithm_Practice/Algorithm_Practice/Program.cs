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
            List<int> file4 = new List<int>();
            List<string> file5 = new List<string>();

            string path1 = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
            string path2 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";
            string path3 = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";
            string path4 = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in_.txt";
            string path5 = AppDomain.CurrentDomain.BaseDirectory + @"Prob05.in_.txt";

            do
            {
                Console.WriteLine("************");
                Console.WriteLine("1. Problem 1*");
                Console.WriteLine("2. Problem 2");
                Console.WriteLine("3. Problem 3");
                Console.WriteLine("4. Problem 4*");
                Console.WriteLine("5. Problem 5*");
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
                    Console.WriteLine("Not Done");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == 3)
                {
                    Console.WriteLine("Not Done");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (input == 4)
                {
                    using (StreamReader sr = new StreamReader(path4))
                    {
                        string line;
                        int numhold = 1;
                        List<int> sol = new List<int>();

                        while ((line = sr.ReadLine()) != null)
                        {
                            file4.Add(int.Parse(line));
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            for (int j = 1; j <= file4[i]; j++)
                            {
                                numhold = numhold * j;
                            }
                            sol.Add(numhold);
                            numhold = 1;
                        }
                        Console.WriteLine();

                        for (int i = 0; i < sol.Count; i++)
                        {
                            Console.WriteLine(sol[i]);
                        }
                        Console.ReadKey();
                        Console.Clear();

                    }
                }

                if (input == 5)
                {
                    string[] key = new string[5];
                    string[] student1 = new string[6];
                    string[] student2 = new string[6];
                    string[] student3 = new string[6];
                    string[] student4 = new string[6];
                    string[] student5 = new string[6];
                    string[] student6 = new string[6];
                    string[] student7 = new string[6];
                    string[] student8 = new string[6];

                    int student1points = 0;
                    int student2points = 0;
                    int student3points = 0;
                    int student4points = 0;
                    int student5points = 0;
                    int student6points = 0;
                    int student7points = 0;
                    int student8points = 0;

                    using (StreamReader sr = new StreamReader(path5))
                    {
                        //getting the multiplier
                        int mult = int.Parse(sr.ReadLine());
                        string line;
                        //adding everything to a file list
                        while ((line = sr.ReadLine()) != null)
                        {
                            file5.Add(line);
                        }
                        //getting the key from the overall list
                        for (int j = 0; j < 5; j++)
                        {
                            key[j] = file5[j];
                        }
                        //getting the answers for student1
                        for (int q = 6; q < 11; q++)
                        {
                            student1[q - 6] = file5[q];
                        }
                        //getting the answers for student2
                        for (int q = 12; q < 17; q++)
                        {
                            student2[q - 12] = file5[q];
                        }
                        //getting the answers for student3
                        for (int q = 18; q < 23; q++)
                        {
                            student3[q - 18] = file5[q];
                        }
                        //getting the answers for student4
                        for (int q = 24; q < 29; q++)
                        {
                            student4[q - 24] = file5[q];
                        }
                        //getting the answers for student5
                        for (int q = 30; q < 35; q++)
                        {
                            student5[q - 30] = file5[q];
                        }
                        //getting the answers for student6
                        for (int q = 36; q < 41; q++)
                        {
                            student6[q - 36] = file5[q];
                        }
                        //getting the answers for student7
                        for (int q = 42; q < 47; q++)
                        {
                            student7[q - 42] = file5[q];
                        }
                        //getting the answers for student8
                        for (int q = 48; q < 53; q++)
                        {
                            student8[q - 48] = file5[q];
                        }

                        //adding up the points
                        for (int i = 0; i < 5; i++)
                        {
                            if (key[i] == student1[i])
                            {
                                student1points++;
                            }
                            if (key[i] == student2[i])
                            {
                                student2points++;
                            }
                            if (key[i] == student3[i])
                            {
                                student3points++;
                            }
                            if (key[i] == student4[i])
                            {
                                student4points++;
                            }
                            if (key[i] == student5[i])
                            {
                                student5points++;
                            }
                            if (key[i] == student6[i])
                            {
                                student6points++;
                            }
                            if (key[i] == student7[i])
                            {
                                student7points++;
                            }
                            if (key[i] == student8[i])
                            {
                                student8points++;
                            }
                        }
                        //printing out the results
                        Console.WriteLine("Student 1: " + student1points * mult);
                        Console.WriteLine("Student 2: " + student2points * mult);
                        Console.WriteLine("Student 3: " + student3points * mult);
                        Console.WriteLine("Student 4: " + student4points * mult);
                        Console.WriteLine("Student 5: " + student5points * mult);
                        Console.WriteLine("Student 6: " + student6points * mult);
                        Console.WriteLine("Student 7: " + student7points * mult);
                        Console.WriteLine("Student 8: " + student8points * mult);

                    }
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (input != 6);

        }
    }
}
