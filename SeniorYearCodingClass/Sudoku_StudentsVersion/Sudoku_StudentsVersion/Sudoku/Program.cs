using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            SudokuBoard board = new SudokuBoard(" ");

            do
            {
                board.PrintBoard();

                Console.WriteLine("********************************************");
                Console.WriteLine("1. Verify the board");
                Console.WriteLine("2. Place a value on the board");
                Console.WriteLine("3. Find legal digits for a given row/column");
                Console.WriteLine("4. Solve the board completely");
                Console.WriteLine("5. Quit");
                Console.WriteLine("********************************************");
                userInput = int.Parse(Console.ReadLine());
                
                if (userInput == 1)
                    VerifyBoard(board);
                   
                if (userInput == 2)
                    PlaceValue(board);
                if (userInput == 3)
                    FindLegalDigits(board);
                    Console.ReadKey();
                if (userInput == 4)
                {
                    
                    if (SolveBoardIterativelyWithQueue(ref board))
                    {
                        Console.WriteLine("The board was solved successfully!");
                        Console.ReadKey();
                        board.PrintBoard();
                    }
                    else
                    {
                        Console.WriteLine("The board was not solved correctly.");
                        Console.ReadKey();
                        board.PrintBoard();

                    }

                }
                Console.Clear();
            } while (userInput != 5);
        }

        static void VerifyBoard(SudokuBoard board)
        {
            if (board.VerifyBoard())
            {
                Console.WriteLine("This board has been solved correctly!");
                
            }
            else
            {
                Console.WriteLine("This board has been solved incorrectly.");
               
            }
        }

        static void PlaceValue(SudokuBoard board)
        {
            int val, row, col;
        GetRow:
            Console.WriteLine("Enter the row that you want to place (X) (0-8)");
            int userInput;
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 8)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetRow;
            }
            row = userInput;

        GetCol:
            Console.WriteLine("Enter the col that you want to place (Y) (0-8)");
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 8)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetCol;
            }
            col = userInput;

        GetVal:
            Console.WriteLine("Enter the value that you want to place (1-9)");
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 9)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetVal;
            }
            val = userInput;

            if (!board.PlaceValue(val, row, col))
            {
                Console.WriteLine("PlaceValue returned false because of an invalid input. Try again.");
                goto GetRow;
            }
        }

        public static void FindLegalDigits(SudokuBoard board)
        {
            int row, col;
        GetRow:
            Console.WriteLine("Enter the row that you want to check (0-8)");
            int userInput;
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 8)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetRow;
            }
            row = userInput;

        GetCol:
            Console.WriteLine("Enter the col that you want to place (0-8)");
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 8)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetCol;
            }
            col = userInput;

            Console.WriteLine();
            foreach (int validVal in board.FindLegalDigits(row, col))
            {
                Console.WriteLine(validVal + " is a legal digit for row " + row + " and column " + col);
            }
            Console.WriteLine();
        }

        public static bool SolveBoardIterativelyWithQueue(ref SudokuBoard board)
        {
            Queue<SudokuBoard> boards = new Queue<SudokuBoard>();
            boards.Push(board);
            List<int> nums = new List<int>();
            while (boards.Count != 0)
            {
                SudokuBoard temp = boards.Pop();

                if (temp.VerifyBoard() == true)
                {
                    board = temp;
                    return true;
                }

                int index1 = 0;
                int index2 = 0;
                bool hasrun = false;

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (temp.Board[i, j] == 0)
                        {
                            index1 = i;
                            index2 = j;

                            nums = temp.FindLegalDigits(i, j);
                            hasrun = true;

                            if (hasrun == true)
                            {
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < nums.Count; i++)
                {
                    SudokuBoard newBoard = new SudokuBoard(temp);
                    newBoard.Board[index1, index2] = nums[i];
                    boards.Push(newBoard);
                }
            }
            return false;
        }
    }
}