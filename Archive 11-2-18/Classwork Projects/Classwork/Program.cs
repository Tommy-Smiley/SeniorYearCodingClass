using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classwork
{
    class Program
    {
        static int input;
        static int x = 0, y = 0;
        static int num1, num2;
        static int[,] multiarray = new int[10, 5];
        static int[][] jaggedArray = new int[10][];
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------
            /*
            //Random rand = new Random();
            List<int> num = new List<int>();
            int i = 0;
            int x = 0;
           while(i < 10)
            {
                Console.WriteLine("Enter a number: ");
                x = int.Parse(Console.ReadLine());
                num.Add(x);
                i++;
            }
            Console.WriteLine();
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(num[j]);
            }
            Console.ReadKey();

            //---------------------------------------------------------------------------------

            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> num = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(num[j]);
            }
            Console.ReadKey();
            Console.WriteLine();

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(num[j]);
            }
            Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                if (array[i] > 5)
                {
                    array[i] = -1;
                }
            }
            for (int j = num.Count - 1; j > 0; j--)
            {
                if (num[j] > 6)
                {
                    num.RemoveAt(j);
                }
            }

            Console.WriteLine("##########################");

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(array[j]);
            }
            Console.ReadKey();
            Console.WriteLine(" ");

            for (int j = 0; j < num.Count - 1; j++)
            {
                Console.WriteLine(num[j]);
            }
            Console.ReadKey();

            //-------------------------------------------------------------------------------
            
            int x = 0;
            int y = 0;
            Random rand = new Random();
            int[] array = new int[10];
            while (x != 4)
            {
                Console.WriteLine("*************************");
                Console.WriteLine("**1. Put rider in seat");
                Console.WriteLine("**2. List available seats");
                Console.WriteLine("**3. Start the ride");
                Console.WriteLine("**4. Quit");
                Console.WriteLine("*************************");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                if (x == 1)
                {
                    int count = 0;
                    for(int i =0;i<array.Length;i++)
                    {
                        count++;
                    }
                    if (count == array.Length)
                    {
                        Console.WriteLine("Coaster is full");
                    }
                    else
                    {
                        do
                        {
                            int selectedChair = rand.Next(0, 10);
                            if (array[selectedChair] == 0)
                            {
                                array[selectedChair] = 1;
                                Console.WriteLine("Person is added to seat " + array[selectedChair]);
                                break;
                            }
                        } while (true);
                    }
                }
                if (x == 2)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        Console.WriteLine(array[j]);
                    }
                }
                if (x == 3)
                {

                }
            }

            //-----------------------------------------------------------------------------------------------
            int x = 0;
            Console.WriteLine("**************");
            Console.WriteLine("1. Add 5 + 6");
            Console.WriteLine("2. Add 11 + 13");
            Console.WriteLine("3. Add 3 + 9");
            Console.WriteLine("4. Quit");
            Console.WriteLine("**************");
            x = int.Parse(Console.ReadLine());

            */


            /*
            do
            {
                menu();
                if (input == 1)
                {
                    Console.WriteLine("Enter the x value");
                    x = int.Parse(Console.ReadLine());
                    Console.Clear();

                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter the y value");
                    y = int.Parse(Console.ReadLine());
                    Console.Clear();

                }
                else if (input == 3)
                {
                    square(x, y);
                    Console.ReadLine();
                    Console.Clear();
                }
              
            } while (input!=4);
            */
            //----------------------------------------------------------------
            /*
            int input;
            do
            {
                Console.WriteLine("********************");
                Console.WriteLine("1. All of the things");
                Console.WriteLine("2. Letter to number");
                Console.WriteLine("3. Quit");
                Console.WriteLine("********************");
                input = int.Parse(Console.ReadLine());
                if(input==1)
                {
                    allthethings();
                    Console.Clear();
                }
                else if(input==2)
                {
                    letters();
                    Console.Clear();
                }
            } while (input != 3);
            */

            //------------------------------------------------------------------------------
            /*
            int x = 0;
            Console.WriteLine("Start");
            Watergun player1 = new Watergun();
            Watergun player2 = new Watergun();

            do
            {
                Console.Write("Player 1: ");
                Console.WriteLine(" 1: SHOOT   2: REFILL");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {

                }
                else if (input == 2)
                {
                    
                }

                Console.Write("Player 2: ");
                Console.WriteLine(" 1: SHOOT   2: REFILL");
                int input2 = int.Parse(Console.ReadLine());
                if (input2 == 1)
                {

                }
                else if (input2 == 2)
                {

                }
                Console.WriteLine("1. FIRE 2. Abort");
                x = int.Parse(Console.ReadLine());
            } while (x != 2);
            */
            //--------------------------------------------------------
            /*
            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the base value: ");
            num2 = int.Parse(Console.ReadLine());

            allradixprint(num1,num2);

            Console.ReadKey();
            */
            //-----------------------------------------------------------
            /*
            int[] array = new int[10];
            int seed = 0;
            Random rand = new Random(seed);

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0,10);
                Console.Write(array[i]);
            }
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }
            Console.WriteLine();
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.ReadKey();
            */
            //-----------------------------------------------------------
            /*
            for (int i = 0; i < multiarray.GetLength(0); i++)
            {
                for (int j = 0; j < multiarray.GetLength(1); j++)
                {
                    multiarray[i, j] = i * j;
                }
            }

            print2Darray(multiarray);
            Console.ReadKey();
            Console.WriteLine();

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }
            }

            printjaggedArray(jaggedArray);
            Console.ReadKey();
            Console.WriteLine();
            */
            //----------------------------------------------------------
            string text = File.ReadAllText(@"C:/Users/136062/OneDrive - Academy District 20/English Class");
            Console.WriteLine(text);
        }

        /*
        static void allthethings()
        {
            for (int i = 0; i <= 13000; i++)
            {
                int num = i;
                char letter = (char)num;
                Console.Write(letter);
            }
            Console.ReadKey();
        }
        static void letters()
        {
            string charlie = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine(charlie[i - 97] + " = " + i);
            }

            Console.ReadKey();
        }
        

            /*
            static int menu()
            {
                Console.WriteLine("**************");
                Console.WriteLine("1. X Value ("+x+")");
                Console.WriteLine("2. Y Value ("+y+")");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Quit");
                Console.WriteLine("**************");
                input = int.Parse(Console.ReadLine());
                return input;
            }


            static void square(int x, int y)
            {
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }
            */
        //-----------------------------------------------------------------
        /*
        static void allradixprint(int num1, int num2)
        {
            int q, r;

            if (num1 < 0)
            {
                num1 = Math.Abs(num1);
                Console.Write("-");
            }

            q = num1 / num2;
            r = num1 - (q * num2);
                
            num1 = q;

            if (q != 0)
            {
                allradixprint(num1, num2);
            }

            Console.Write(r);

        }
        */
        //---------------------------------------------------------------------
        /*
        static void print2Darray(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("|" + x[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        static void printjaggedArray(int[][] y)
        {
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y[i].Length; j++)
                {
                    Console.Write("|" + y[i][j] + "|");
                }
                Console.WriteLine();
            }
        }
        */
        //-------------------------------------------------------------------
    }
}









