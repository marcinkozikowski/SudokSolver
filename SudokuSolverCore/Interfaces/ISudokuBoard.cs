namespace SudokuSolverCore
{
    public interface ISudokuBoard
    {
        /// <summary>
        /// Sudoku board to solve
        /// </summary>
        int[,] Board { get;}
        
        /// <summary>
        /// Number indicating an empty field, '0' by default
        /// </summary>
        int EmptyNum { get; set; }
        
        void PrintToConsole();
    }
}