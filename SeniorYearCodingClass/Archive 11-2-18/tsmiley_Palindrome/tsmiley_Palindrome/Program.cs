using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsmiley_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String back = "";
            Console.WriteLine("Enter a string: ");
            String word = Console.ReadLine();

            word = word.Replace(" " , "").ToLower();

            for (int i = 1; i <= word.Length; i++)
            {
                back += (word[word.Length - i]);
            }
            if (word == back)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
