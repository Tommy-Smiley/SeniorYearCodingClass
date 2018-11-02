using System;

namespace ASCII_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("** 1. Square 1   **");
                Console.WriteLine("** 2. Square 2   **");
                Console.WriteLine("** 3. Square 3   **");
                Console.WriteLine("** 4. Triangle 1 **");
                Console.WriteLine("** 5. Triangle 2 **");
                Console.WriteLine("** 6. Triangle 3 **");
                Console.WriteLine("** 7. Special 1  **");
                Console.WriteLine("** 8. Special 2  **");
                Console.WriteLine("** 9. Special 3  **");
                Console.WriteLine("** 0. Quit       **");
                Console.WriteLine("*******************");
                num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    for(int i = 0 ; i < 1 ; i++)
                    {
                        for(int j = 0 ; j < 1; j++)
                        {
                            Console.WriteLine("X");
                        }
                    }
                }
                else if (num == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine("");
                    }
                }
                else if (num == 3)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine("");
                    }
                }
                else if (num == 4)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = (5 - i); j < 6; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine("");
                    }
                }
                else if (num == 5)
                { 
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j <= i)
                            {
                                Console.Write("X");
                            }
                            else Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (num == 6)
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j = 3; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = i + (i-1); k > 0; k--)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine("");
                    }
                }
                else if (num == 7)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == j)
                            {
                                Console.Write(" ");
                            }
                            else Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (num == 8)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - j ==i)
                            {
                                Console.Write(" ");
                            }
                            else Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
                else if (num == 9)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == j || 4 - j == i)
                            {
                                Console.Write(" ");
                            }
                            else Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
