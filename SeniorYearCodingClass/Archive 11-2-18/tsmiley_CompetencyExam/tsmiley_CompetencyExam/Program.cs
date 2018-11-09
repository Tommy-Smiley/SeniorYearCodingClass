using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsmiley_CompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                //menu
                Console.WriteLine("****************");
                Console.WriteLine("1.  Conditionals");
                Console.WriteLine("2.  For loops");
                Console.WriteLine("3.  While loops");
                Console.WriteLine("4.  Arrays");
                Console.WriteLine("5.  lists");
                Console.WriteLine("-1. Quit");
                Console.WriteLine("****************");
                input = int.Parse(Console.ReadLine());
                //first input
                if (input == 1)
                {
                    //collect input
                    int grade = 0;
                    int read = 0;
                    string level = "";

                    Console.Write("Enter your grade: ");
                    grade = int.Parse(Console.ReadLine());

                    Console.Write("Enter your reading grade level: ");
                    read = int.Parse(Console.ReadLine());
                    //check and store level variable for the correct grade level
                    if (grade >= 9 && grade <= 12)
                        level = "High School";
                    else if (grade >= 6 && grade <= 8)
                        level = "Middle School";
                    else
                        level = "Elementary School";
                    //determine if the reading level is proficient or not
                    if (grade <= read)
                    {
                        Console.WriteLine("You are in " + level + " and read at a proficient level.");
                    }
                    else
                        Console.WriteLine("You do not read at a proficient level. Go study.");
                }
                //second input
                else if (input == 2)
                {
                    //collect input
                    int countBy = 0;
                    int countTo = 0;
                    Console.Write("Pick a number to count by: ");
                    countBy = int.Parse(Console.ReadLine());
                    Console.Write("Pick a number to count to: ");
                    countTo = int.Parse(Console.ReadLine());
                    //interate though using for loop under the input cnoditions
                    for (int i = 0; i <= countTo; i += countBy)
                    {
                        Console.WriteLine(i);
                    }
                }
                //third input
                else if (input == 3)
                {
                    //collect input
                    int num = -1;
                    int sum = 0;
                    Console.WriteLine("The sum starts at 0 add numbers to add to the sum. 0 ends.");
                    while (num != 0)
                    {
                        //add numbers infinitly until 0 is an input
                        Console.Write("Add number: ");
                        num = int.Parse(Console.ReadLine());
                        sum += num;
                        Console.WriteLine("Total: " + sum);
                    }
                    //write the total out
                    Console.WriteLine("The grand total is: " + sum);
                }
                //fourth input
                else if (input == 4)
                {
                    int[] array = new int[10];
                    //go though the array and assign numbers
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("Enter a number to put into the array (10 total): ");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    //once full write it out
                    Console.WriteLine("Your final array is:");
                    for (int j = 0; j < 10; j++)
                    {
                        
                        Console.WriteLine("Index "+j+ " = " + array[j]);
                    }
                }
                //fifth input
                else if (input == 5)
                {
                    int i = 0;
                    string lis;
                    bool ned=true;
                    List<string> words = new List<string>();

                    Console.WriteLine("Enter values into a list. enter end to exit");
                    do
                    {
                        //enter strings until end is entered
                        Console.Write("Enter a word: ");
                        lis = Console.ReadLine();
                        words.Add(lis);
                        i++;
                        //if end is entered set variable to false breaking out of the while loop
                        if (lis == "end")
                        {
                            ned = false;
                        }
                    } while (ned);
                    for (int k = 0; k < i; k++)
                    {
                        //print back out the list of strings
                        Console.WriteLine("Index "+k+" = " + words[k]);
                    }
                }
                //exit program
            } while (input != -1);

        }
    }
}
