using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.WriteLine("***************************************************************************************************************");
                Console.WriteLine("1. Print Hello world");
                Console.WriteLine("2. Add two user input integers together");
                Console.WriteLine("3. Calulcate the area of a circle given just the radius from user input");
                Console.WriteLine("4. Calculate the area of a triangle given the length of all three sides from user input");
                Console.WriteLine("5. Given an integer n from user input, draw a square using the ASCII character 'X' that has the width of n");
                Console.WriteLine("6. Given an integer n from user input, draw a hollow square using the ASCII character 'X' that has a width of n");
                Console.WriteLine("7. Given two integer variables from user input, swap their values");
                Console.WriteLine("8. Reverse a string from user input using a for loop");
                Console.WriteLine("9. Quit");
                Console.WriteLine("***************************************************************************************************************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Hello World");
                    Console.ReadKey();
                }
                if (input == 2)
                {
                    int num1 = 0;
                    int num2 = 0;
                    int adumup = 0;
                    Console.Clear();
                    Console.Write("Enter the fist number: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    adumup = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + adumup);
                    Console.ReadKey();
                }
                if (input == 3)
                {
                    Console.Clear();
                    int radius = 0;
                    double area = 0;
                    Console.Write("Enter the radius of the circle: ");
                    radius = int.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    Console.Clear();
                    Console.WriteLine("The area of the circle is: " + area + " units ^2");
                    Console.ReadKey();
                }
                if (input == 4)
                {
                    Console.Clear();
                    int side1 = 0;
                    int side2 = 0;
                    int side3 = 0;
                    int p = 0;
                    double area = 0;
                    Console.Write("Enter the first side length: ");
                    side1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second side length: ");
                    side2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the third side length: ");
                    side3 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    p = ((side1 + side2 + side3) / 2);
                    area = Math.Sqrt((p - side1) * (p - side2) * (p - side3) * p);
                    Console.WriteLine("The area of the triangle is : " + area + " units ^2");
                    Console.ReadKey();
                }
                if (input == 5)
                {
                    Console.Clear();
                    int width = 0;
                    Console.Write("Enter the width of the square: ");
                    width = int.Parse(Console.ReadLine());
                    Console.Clear();
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                if (input == 6)
                {
                    Console.Clear();
                    int width = 0;
                    Console.Write("Enter the width of the square: ");
                    width = int.Parse(Console.ReadLine());
                    Console.Clear();
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || j == 0 || i == width - 1 || j == width - 1)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
                if (input == 7)
                {
                    Console.Clear();
                    int value1 = 0;
                    int value2 = 0;
                    int holder1 = 0;
                    int holder2 = 0;
                    Console.Write("Enter the first value: ");
                    value1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the second value: ");
                    value2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    holder1 = value1;
                    holder2 = value2;
                    value1 = holder2;
                    value2 = holder1;
                    Console.WriteLine("The first value is now: " + value1);
                    Console.WriteLine("The second value is now: " + value2);
                    Console.ReadKey();
                }
                if (input == 8)
                {
                    Console.Clear();
                    string word = "";
                    string re = "";
                    Console.Write("Enter a string to reverse: ");
                    word = Console.ReadLine();
                    Console.Clear();
                    for (int i = word.Length - 1; i >= 0; i--)
                    {
                        re += word[i];
                    }
                    Console.WriteLine(re);
                    Console.ReadKey();
                }

            } while (input != 9);
        }
    }
}
