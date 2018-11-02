using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsmiley_Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 4;

            while (option != 3)
            {
                //start menu
                Console.WriteLine("*******************");
                Console.WriteLine("**1. You guess");
                Console.WriteLine("**2. Computer guess");
                Console.WriteLine("**3. Quit");
                Console.WriteLine("*******************");
                option = int.Parse(Console.ReadLine());
                //USER GUESS
                if (option == 1)
                {
                    //create a random number between 1 and 1000
                    Random rand = new Random();
                    int randnumber = rand.Next(0, 1000);
                    //create count variable equal to 0
                    int count = 1;
                    int guess;
                    //ask the user to guess the number between 1 and 1000 and store in guess
                    Console.WriteLine("Guess a number between 1 and 1000");
                    guess = int.Parse(Console.ReadLine());
                    //create a while loop that loops while guess does not equal number
                    while (guess != randnumber)
                    {
                        //if the guess is lower than number print higher
                        if (guess < randnumber)
                        {
                            Console.WriteLine("Higher");
                        }
                        //if the guess is higher than number prints lower
                        if (guess > randnumber)
                        {
                            Console.WriteLine("Lower");
                        }
                        //ask the user to guess the number between 1 and 1000 and store in guess
                        Console.WriteLine("Guess again");
                        guess = int.Parse(Console.ReadLine());
                        //count variable up by one
                        count++;
                    }
                    //if the guess equals the number print correct breaking out of the while loop
                    Console.WriteLine("Correct");
                    //print out the count variable
                    Console.WriteLine("It took you " + count + " attempts.");
                    Console.ReadKey();
                }
                //COMPUTER GUESS
                else if (option == 2)
                {
                    //set up variables
                    int ans;
                    int old = 500;
                    int num = 500;
                    int count = 1;
                    //get user input of the innitial higher or lower
                    Console.WriteLine("Think of a number between 1 and 1000");
                    Console.WriteLine("Is it higher or lower than 500?(1 is lower, 2 is higher, 3 is correct)");
                    ans = int.Parse(Console.ReadLine());

                    while (ans != 3)
                    {
                        if (ans == 1)
                        {
                            //if the number is lower make the last halfway point the high point
                            old /= 2;
                            num = num - old;
                            Console.WriteLine(num);
                            ans = int.Parse(Console.ReadLine());
                            count++;
                        }
                        else if (ans == 2)
                        {
                            //if the number is higer make thelast halfway point the low point
                            old /= 2;
                            num = num + old;
                            Console.WriteLine(num);
                            ans = int.Parse(Console.ReadLine());
                            count++;
                        }
                        else if ((ans >= 4) || (ans <=0))
                        {
                            //if the user inputs incorrect input program no crash
                            Console.WriteLine("Invalid");
                            ans = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("It took me " + count + " attempts.");
                    Console.ReadKey();
                }
            }
        }
    }
}
