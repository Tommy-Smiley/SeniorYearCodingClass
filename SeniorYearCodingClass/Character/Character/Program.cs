using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            List<Character> characters = new List<Character>();
            do
            {
                Console.WriteLine("****************************");
                Console.WriteLine("**1. Create a Character");
                Console.WriteLine("**2. Modify a Character");
                Console.WriteLine("**3. Delete a Character");
                Console.WriteLine("**4. Load Existing Character");
                Console.WriteLine("**5. List Characters");
                Console.WriteLine("**6. Exit");
                Console.WriteLine("****************************");
                input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    characters.Add(CreateCharacter());
                }
                if (input == 2)
                {

                }
                if (input == 3)
                {

                }
                if (input == 4)
                {

                }
                if (input == 5)
                {

                }
            } while (input != 6);
        }
        static Character CreateCharacter()
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter an age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter a height: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Enter an eyecolor: ");
            string eyecolor = Console.ReadLine();
            Console.Write("Enter a gender: ");
            string gender = Console.ReadLine();
            
        }
        static void ModifyCharacter(Character character)
        {

        }
        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.name + ".txt";
            using (StringWriter sw = new StringWriter(path))
            {
                sw.WriteLine(character);
            }
        }
        static bool DeleteCharacter(List<Character> characters, string characterName)
        {
            return true;
        }
        static Character LoadCharacter(string characterName)
        {
            return null;
        }
        static List<Character> LoadCharacters()
        {
            return null;
        }
        static void ListCharacter(List<Character> characters)
        {

        }

    }

}
