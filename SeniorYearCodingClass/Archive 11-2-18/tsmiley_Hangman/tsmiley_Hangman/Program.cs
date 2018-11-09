using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsmiley_Hangman
{
    class Program
    {
        static List<char> guess = new List<char>();
        static int i = 0;
        static void Main(string[] args)
        {
            string[] words = new string[30];
            words[0] = "test";
            words[1] = "pickle";
            words[2] = "questionable";
            words[3] = "plucky";
            words[4] = "horse";
            words[5] = "black";
            words[6] = "rail";
            words[7] = "volleyball";
            words[8] = "frequent";
            words[9] = "excited";
            words[10] = "tree";
            words[11] = "branch";
            words[12] = "meal";
            words[13] = "breath";
            words[14] = "friends";
            words[15] = "overconfident";
            words[16] = "deep";
            words[17] = "cooing";
            words[18] = "tap";
            words[19] = "strange";
            words[20] = "salt";
            words[21] = "cap";
            words[22] = "country";
            words[23] = "mess";
            words[24] = "royal";
            words[25] = "sore";
            words[26] = "trouble";
            words[27] = "clip";
            words[28] = "scattered";
            words[29] = "exultant";
            Random rand = new Random();
            string word = words[rand.Next(0, 29)];
            int x = 0;
            int isCorrect =0;
            int count = 6;
            Console.WriteLine("Welcome hangman awaits");
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("^");
            }
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("You have " + (count) + " guesses ramaining");
                Console.Write("Guess a letter: ");
                guess.Add(char.Parse(Console.ReadLine()));
                for (i = 0; i < word.Length; i++)
                {

                    if (guess.Contains(word[i]))
                    {
                        Console.Write(word[i]);
                    }
                    else
                    {
                        Console.Write("^");
                    }
                }
                if(word.Contains(guess[x]))
                {
                    isCorrect++;
                    x++;
                }
                else
                {
                    count--;
                    x++;
                }
                Console.Write("Guessed Letters: ");
                for(int j=0;j<guess.Count;j++)
                {
                    Console.Write(guess[j]+",");
                }

                Console.WriteLine();

            } while (count != 0 && isCorrect != word.Length);

            if(isCorrect == word.Length)
            {
                Console.WriteLine();
                Console.WriteLine("Congrats the word is " + word);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Game over. The word was " + word);
            }

            Console.ReadLine();
        }
    }
}
