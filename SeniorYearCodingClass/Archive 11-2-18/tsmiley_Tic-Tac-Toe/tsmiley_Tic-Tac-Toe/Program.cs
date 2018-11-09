using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsmiley_Tic_Tac_Toe
{
    class Program
    {
        static string[,] array = new string[3, 3];
        static int x = 0;
        static int y = 0;
        static bool winner = false;
        static int count = 0;
        static int error = 0;
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = " ";
                }
            }

            do
            {
                if (count % 2 == 0)
                {
                    Console.Write("( X ) Enter the X spot: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("( X ) Enter the Y spot: ");
                    y = int.Parse(Console.ReadLine());
                }
                if (count % 2 != 0)
                {
                    Console.Write("( O ) Enter the X spot: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("( O ) Enter the Y spot: ");
                    y = int.Parse(Console.ReadLine());
                }

                if (x > 2 || y > 2 || x < 0 || y < 0)
                {
                    Console.WriteLine("\n**ERROR**\n");
                    error = 1;
                }
                else
                {
                    if (array[x, y] == ("X"))
                    {
                        Console.WriteLine("\n**ERROR**\n");
                        error = 1;
                    }
                    if (array[x, y] == ("O"))
                    {
                        Console.WriteLine("\n**ERROR**\n");
                        error = 1;
                    }
                    if ((count % 2 == 0) && (error == 0))
                    {
                        array[x, y] = "X";
                        count++;
                    }
                    else if ((count % 2 != 0) && (error == 0))
                    {
                        array[x, y] = "O";
                        count++;
                    }
                }

                error = 0;
                print(array);
                win(array);

            } while (!winner);
            Console.ReadKey();
        }

        static void print(string[,] arrayz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + arrayz[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        static void win(string[,] arrayz)
        {
            if (arrayz[0, 0] == "X" && arrayz[0, 1] == "X" && arrayz[0, 2] == "X" ||
                arrayz[1, 0] == "X" && arrayz[1, 1] == "X" && arrayz[1, 2] == "X" ||
                arrayz[2, 0] == "X" && arrayz[2, 1] == "X" && arrayz[2, 2] == "X" ||
                arrayz[0, 0] == "X" && arrayz[1, 0] == "X" && arrayz[2, 0] == "X" ||
                arrayz[0, 1] == "X" && arrayz[1, 1] == "X" && arrayz[2, 1] == "X" ||
                arrayz[0, 2] == "X" && arrayz[1, 2] == "X" && arrayz[2, 2] == "X" ||
                arrayz[0, 0] == "X" && arrayz[1, 1] == "X" && arrayz[2, 2] == "X" ||
                arrayz[0, 2] == "X" && arrayz[1, 1] == "X" && arrayz[2, 0] == "X")
            {
                winner = true;
                Console.WriteLine("\n**X WINZ**\n");
            }

            if (arrayz[0, 0] == "O" && arrayz[0, 1] == "O" && arrayz[0, 2] == "O" ||
                arrayz[1, 0] == "O" && arrayz[1, 1] == "O" && arrayz[1, 2] == "O" ||
                arrayz[2, 0] == "O" && arrayz[2, 1] == "O" && arrayz[2, 2] == "O" ||
                arrayz[0, 0] == "O" && arrayz[1, 0] == "O" && arrayz[2, 0] == "O" ||
                arrayz[0, 1] == "O" && arrayz[1, 1] == "O" && arrayz[2, 1] == "O" ||
                arrayz[0, 2] == "O" && arrayz[1, 2] == "O" && arrayz[2, 2] == "O" ||
                arrayz[0, 0] == "O" && arrayz[1, 1] == "O" && arrayz[2, 2] == "O" ||
                arrayz[0, 2] == "O" && arrayz[1, 1] == "O" && arrayz[2, 0] == "O")
            {
                winner = true;
                Console.WriteLine("\n**O WINZ**\n");
            }
            else if (count >= 9)
            {
                Console.WriteLine("\n**Tie**\n");
                winner = true;
            }
        }

    }
}
