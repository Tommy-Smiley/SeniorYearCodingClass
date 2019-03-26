using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class Program
    {
        static Deck deck = new Deck();

        static int end = 0;
        static int player1cards = 0;
        static int player2cards = 0;

        static List<Card> deck1 = new List<Card>();
        static List<Card> deck2 = new List<Card>();

        static void Main(string[] args)
        {
            int input = 0;
            List<int> Hand = new List<int>();

            do
            {
                Console.WriteLine("********");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Rules");
                Console.WriteLine("3. Quit");
                Console.WriteLine("********");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    deck.Shuffle();

                    for (int i = 0; i < 26; i++)
                    {
                        deck1.Add(deck.Draw());
                        player1cards++;
                    }

                    for (int i = 26; i < 52; i++)
                    {
                        deck2.Add(deck.Draw());
                        player2cards++;
                    }

                    do
                    {
                        string input2 = "";

                        end = player1();
                        end = player2();

                        int result = deck1[deck1.Count - 1].Compare(deck2[deck2.Count - 1]);

                        if (result == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Player 1 wins this round!");
                            Console.WriteLine();
                            Playeronewin();
                        }

                        if (result == -1)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Player 2 wins this round!");
                            Console.WriteLine();
                            Playertwowin();
                        }

                        if (result == 2)
                        {
                            Card c = deck1[deck1.Count - 1];
                            deck1.RemoveAt(deck1.Count - 1);
                            deck1.Insert(0, c);
                        }

                        Console.WriteLine("Do you want to keep playing? (y or n)");
                        input2 = Console.ReadLine();

                        if (input2[0] == 'y' || input2[0] == 'Y')
                        {
                            end = 5;
                        }

                        if (input2[0] == 'n' || input2[0] == 'N')
                        {
                            end = 4;
                        }

                        if (input2[0] != 'y' && input2[0] != 'Y' && input2[0] != 'n' && input2[0] != 'N')
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input try again: (y or n)");
                            input2 = Console.ReadLine();
                        }

                        Console.Clear();

                    } while (end != 4);
                    
                }

                if (input == 2)
                {
                    rules();
                }

            } while (input != 3);
        }

        static int player1()
        {
            Console.WriteLine();
            Console.WriteLine("Player 1: ");
            deck1[deck1.Count - 1].print();

            if (player1cards > 1)
            { 
                Console.WriteLine("Player 1 has " + player1cards + " cards left.");
                return 5;
            }

            if (player1cards == 1)
            {
                Console.WriteLine("Player 1 has " + player1cards + " card left.");
                return 5;
            }

            if (player2cards == 52)
            {
                Console.WriteLine("Player 2 has won the game!");
                return 4;
            }

            return 0;

        }

        static int player2()
        {
            Console.WriteLine();
            Console.WriteLine("Player 2:");
            deck2[deck2.Count - 1].print();

            if (player2cards > 1)
            {   
                Console.WriteLine("Player 2 has " + player2cards + " cards left.");
                return 5;
            }

            if (player2cards == 1)
            {
                Console.WriteLine("Player 2 has " + player2cards + " card left.");
                return 5;
            }

            if (player2cards == 0)
            {
                Console.WriteLine("Player 1 has won the game!");
                return 4;
            }

            return 0;
        }

        static void rules()
        {
            Console.Clear();
            Console.WriteLine(">>>WAR<<<");
            Console.WriteLine("How to win: Get all them cards.");
            Console.WriteLine("How to get all them cards: each player puts down a card the highest card keeps both, if tie each place down 4 more and the last one whoever is higher wins.");
            
        }

        static void Playeronewin()
        {
            Card c = deck1[deck1.Count - 1];

            deck1.RemoveAt(deck1.Count - 1);
            deck1.Insert(0, deck2[deck2.Count - 1]);
            deck1.Insert(0, c);
            deck2.RemoveAt(deck2.Count - 1);

            player2cards--;
            player1cards++;
        }

        static void Playertwowin()
        {
            Card c = deck2[deck2.Count - 1];

            deck2.RemoveAt(deck2.Count - 1);
            deck2.Insert(0, deck1[deck1.Count - 1]);
            deck2.Insert(0, c);
            deck1.RemoveAt(deck1.Count - 1);

            player1cards--;
            player2cards++;

        }
    }
}