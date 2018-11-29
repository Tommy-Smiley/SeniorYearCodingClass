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
                Console.WriteLine("**3. Save a Character");
                Console.WriteLine("**4. Delete a Character");
                Console.WriteLine("**5. List Characters");
                Console.WriteLine("**6. Exit");
                Console.WriteLine("****************************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    characters.Add(CreateCharacter());
                    Console.Clear();
                }
                if (input == 2)
                {
                    characters = LoadCharacters(AppDomain.CurrentDomain.BaseDirectory);
                    ModifyCharacter(characters);
                    Console.Clear();
                }
                if (input == 3)
                {
                    SaveCharacter(characters);
                    Console.Clear();
                }
                if (input == 4)
                {
                    Console.WriteLine("Enter the file name: ");
                    DeleteCharacter(AppDomain.CurrentDomain.BaseDirectory + Console.ReadLine() + ".txt");
                    Console.Clear();
                }
                if (input == 5)
                {
                    characters = LoadCharacters(AppDomain.CurrentDomain.BaseDirectory);
                    ListCharacter(characters);
                }
            } while (input != 6);

        }

        static Character CreateCharacter()
        {
            Character character = new Character();

            Console.Write("Enter a name: ");
            character.name = Console.ReadLine();
            Console.Write("Enter an age: ");
            character.age = int.Parse(Console.ReadLine());
            Console.Write("Enter a height: ");
            character.height = float.Parse(Console.ReadLine());
            Console.Write("Enter an eyecolor: ");
            character.eyecolor = Console.ReadLine();
            Console.Write("Enter a gender: ");
            character.gender = Console.ReadLine();

            Console.WriteLine("\n**Created**");
            Console.ReadKey();

            return character;

        }

        static Character ModifyCharacter(List<Character> characters)
        {

            Console.Write("Enter a file name: ");
            string findname = Console.ReadLine();

            Character modify = new Character();

            for (int i = 0; i < characters.Count; i++)
            {
                if (findname == characters[i].name)
                {
                    modify = characters[i];
                }
            }

            Console.Write("Enter an age: ");
            modify.age = int.Parse(Console.ReadLine());
            Console.Write("Enter a height: ");
            modify.height = float.Parse(Console.ReadLine());
            Console.Write("Enter an eyecolor: ");
            modify.eyecolor = Console.ReadLine();
            Console.Write("Enter a gender: ");
            modify.gender = Console.ReadLine();

            Console.WriteLine("\n**Modified**");
            Console.ReadKey();

            return modify;
        }

        static void SaveCharacter(List<Character> characters)
        {
            for (int i = 0; i < characters.Count; i++)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + characters[i].name + ".txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(characters[i].name + "\r\n" + characters[i].age + "\r\n" + characters[i].height + "\r\n" + characters[i].eyecolor + "\r\n" + characters[i].gender);
                }
            }
            Console.WriteLine("\n**Saved**");
            Console.ReadKey();
        }

        static void DeleteCharacter(string path)
        {
            File.Delete(path);
            Console.WriteLine("\n**Deleted**");
            Console.ReadKey();
        }

        static List<Character> LoadCharacters(string path)
        {
            List<Character> temp = new List<Character>();

            foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    Character character = new Character();
                    character.name = sr.ReadLine();
                    character.age = int.Parse(sr.ReadLine());
                    character.height = float.Parse(sr.ReadLine());
                    character.eyecolor = sr.ReadLine();
                    character.gender = sr.ReadLine();
                    temp.Add(character);
                }
            }
            return temp;

        }

        static void ListCharacter(List<Character> characters)
        {
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine(characters[i].name);
                Console.WriteLine(characters[i].age);
                Console.WriteLine(characters[i].height);
                Console.WriteLine(characters[i].eyecolor);
                Console.WriteLine(characters[i].gender);
                Console.WriteLine();
            }
            Console.WriteLine("**Listed**");
            Console.ReadKey();
            Console.Clear();
        }

    }

}
