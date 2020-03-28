using System;

namespace SudokuSolverCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...:::\tSudoku Solver !\t:::...");
            
            var solver = new SudokuSolver();
            
            var boardToSolve = new SudokuBoard(new int[9,9]{ 
                {5,3,0,0,7,0,0,0,0}, 
                {6,0,0,1,9,5,0,0,0}, 
                {0,9,8,0,0,0,0,6,0}, 
                {8,0,0,0,6,0,0,0,3},
                {4,0,0,8,0,3,0,0,1},
                {7,0,0,0,2,0,0,0,6},
                {0,6,0,0,0,0,2,8,0},
                {0,0,0,4,1,9,0,0,5},
                {0,0,0,0,8,0,0,7,9}
            });
            Console.WriteLine("\n  << Sudko to solve >>");
            boardToSolve.PrintToConsole();

            var solvedBoard = solver.Solve(boardToSolve);
            
            Console.WriteLine("\n  << Solved Sudoku >>");
            
            solvedBoard.PrintToConsole();
        }
    }
}