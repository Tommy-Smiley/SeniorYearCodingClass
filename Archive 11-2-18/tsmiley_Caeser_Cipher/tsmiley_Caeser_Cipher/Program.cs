using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsmiley_Caeser_Cipher
{
    class Program
    {
        static string input;
        static int shiftVal;
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("***************");
                Console.WriteLine("1. Encrypt");
                Console.WriteLine("2. Decrypt");
                Console.WriteLine("3. Brute Force");
                Console.WriteLine("4. Quit");
                Console.WriteLine("***************");
                num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.Write("Enter a string to encrypt: ");
                    input = Console.ReadLine();
                    Console.Write("Enter a number to shift: ");
                    shiftVal = int.Parse(Console.ReadLine());
                    encrypt(input, shiftVal);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (num == 2)
                {
                    Console.Write("Enter a string to decrypt: ");
                    input = Console.ReadLine();
                    Console.Write("Enter a number to shift: ");
                    shiftVal = int.Parse(Console.ReadLine());
                    decrypt(input, shiftVal);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (num == 3)
                {
                    Console.Write("Enter a string to absolutly brute force: ");
                    input = Console.ReadLine();
                    bruteForce(input);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (num != 4);
        }
        static void encrypt(string input, int shiftVal)
        {
            List<char> word = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                word.Add(input[i]);
                word[i] = (char)(word[i] + shiftVal);
                if ((int)word[i] > 122)
                    word[i] = (char)(word[i] - 26);
                if ((int)word[i] < 97)
                    word[i] = (char)(word[i] + 26);
            }

            for (int i = 0; i < word.Count; i++)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }

        static void decrypt(string input, int shiftVal)
        {
            List<char> word = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                
                word.Add(input[i]);
                word[i] = (char)(word[i] - shiftVal);
                if ((int)word[i] > 122)
                    word[i] = (char)(word[i] - 26);
                if ((int)word[i] < 97)
                    word[i] = (char)(word[i] + 26);
            }

            for (int i = 0; i < word.Count; i++)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }

        static void bruteForce(string input)
        {
            List<char> word = new List<char>();
            List<char> word2 = new List<char>();
            for (int j = 0; j < 26; j++)
            {

                for (int i = 0; i < input.Length; i++)
                {

                    word.Add(input[i]);
                    word2.Add(input[i]);
                    word2[i] = (char)(word[i] + j);
                    if ((int)word2[i] > 122)
                        word2[i] = (char)(word2[i] - 26);
                    if ((int)word2[i] < 97)
                        word2[i] = (char)(word2[i] + 26);
                    Console.Write(word2[i]);
                }
                Console.WriteLine();

            }
            
        }
    }
}
