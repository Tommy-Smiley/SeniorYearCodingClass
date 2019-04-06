using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SudokuBoard
    {
        int counter = 0;

        List<string> boards = new List<string>();
        string newBoard;
        
        int mrr = -1, mrc = -1;
        int[,] userChangedColors = new int[9, 9];

        public int[,] Board { get; set; } = new int[9, 9];

        public SudokuBoard()
        {
            Board = new int[9, 9] {
                {0,0,0,2,6,0,7,0,1 },
                {6,8,0,0,7,0,0,9,0},
                {1,9,0,0,0,4,5,0,0 },
                {8,2,0,1,0,0,0,4,0 },
                {0,0,4,6,0,2,9,0,0 },
                {0,5,0,0,0,3,0,2,8 },
                {0,0,9,3,0,0,0,7,4 },
                {0,4,0,0,5,0,0,3,6 },
                {7,0,3,0,1,8,0,0,0 }};
        }

        public SudokuBoard(string fileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"HardPuzzles.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                Random rand = new Random();
                while ((line = sr.ReadLine()) != null)
                {
                    boards.Add(line);
                }
                
                newBoard = boards[rand.Next(0, boards.Count)];
                int index = 0;

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Board[i, j] = int.Parse(newBoard[index].ToString());
                        index++;
                    }
                }
            }
        }

        public SudokuBoard(SudokuBoard board)
        {
            Array.Copy(board.Board, this.Board, this.Board.Length);
        }
        
        public bool VerifyBoard()
        {
            List<int> Num = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
     
            for (int k = 0; k < 9; k++)
            {
                Num.Clear();

                for (int j = 0; j < 9; j++)
                {
                    Num.Add(Board[j, k]);
                }

                Num = Num.OrderBy(t => t).ToList();

                for (int j = 1; j < 9; j++)
                {
                    if (!Num.Contains(j))
                    {
                        return false;
                    }
                }
            }

            for (int k = 0; k < 9; k++)
            {
                Num.Clear();

                for (int j = 0; j < 9; j++)
                {
                    Num.Add(Board[k, j]);
                }

                Num = Num.OrderBy(t => t).ToList();

                for (int j = 1; j < 9; j++)
                {
                    if (!Num.Contains(j))
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Num.Clear();

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            Num.Add(Board[j + i * 3, k + l * 3]);
                        }
                    }
                      
                    for (int m = 1; m <= 9; m++)
                    {
                        if (!Num.Contains(m))
                        {
                            return false;
                        }
                    }

                }
            }

            return true;
        }

        public List<int> FindLegalDigits(int row, int col)
        {
            List<int> possibleNum = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < 9; i++)
            {
                possibleNum.Remove(Board[row, i]);
            }

            for (int i = 0; i < 9; i++)
            {
                possibleNum.Remove(Board[i, col]);
            }

            for (int j = row - (row % 3); j < row - (row % 3) + 3; j++)
            {
                for (int k = col - (col % 3); k < col - (col % 3) + 3; k++)
                {
                    possibleNum.Remove(Board[j, k]);
                }
            }
  
            return possibleNum;
        }

        public void PrintBoard()
        {
            Console.WriteLine("Y  0  1  2   3  4  5   6  7  8");
            Console.WriteLine("X  ---------------------------");
            for (int row = 0; row < 9; row++)
            {
                if (row % 3 == 0 && row != 0)
                {
                    Console.WriteLine("  ---------+---------+---------");
                }
                Console.Write(row + "|");
                for (int col = 0; col < 9; col++)
                {
                    if (col % 3 == 0 && col != 0)
                    {
                        Console.Write("|");
                    }
                    if (mrr == row && mrc == col)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (userChangedColors[row, col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(" " + Board[row, col] + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
                counter = 0;
            }
        }

        public bool PlaceValue(int val, int row, int col)
        {
            if (val < 0 || val > 8 || row < 0 || row > 8 || col < 0 || col > 8)
                return false;

            mrr = row;
            mrc = col;

            userChangedColors[row, col] = 1;


            Board[row, col] = val;
            return true;
        }
    }
}
