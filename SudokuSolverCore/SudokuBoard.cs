using System;

namespace SudokuSolverCore
{
    public class SudokuBoard : ISudokuBoard
    {
        private int[,] _borad;
        private int _emptyNum = 0;
        
        public int EmptyNum
        {
            get { return _emptyNum;}
            set { _emptyNum = value; }
        }
        
        public int[,] Board
        {
            get { return _borad; }
        }
        
        public SudokuBoard(int[,] board)
        {
            _borad = board;
            _emptyNum = 0;
        }

        public void PrintToConsole()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (_borad[i, j] == _emptyNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($" {_borad[i, j]} ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}