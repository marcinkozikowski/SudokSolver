namespace SudokuSolverCore
{
    public interface ISudokuSolver
    {
        /// <summary>
        /// Solves given sudoku board
        /// </summary>
        /// <param name="board">Sudoku board to solve</param>
        /// <returns>Solved board</returns>
        ISudokuBoard Solve(ISudokuBoard board);
    }
}