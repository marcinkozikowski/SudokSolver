using System;

namespace SudokuSolverCore
{
    public class SudokuSolver : ISudokuSolver
    {
        private ISudokuBoard _workingBoard;
        public SudokuSolver(){}

        public SudokuSolver(ISudokuBoard board)
        {
            _workingBoard = board;
        }

        public ISudokuBoard Solve(ISudokuBoard board)
        {
            _workingBoard = board;

            if (!PerformSolver())
            {
                throw new ArgumentException("Can not solve that sudoku :(");
            };
            return _workingBoard;
        }

        private bool PerformSolver()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (_workingBoard.Board[row,column] == _workingBoard.EmptyNum)
                    {
                        return TryToFillCell(row,column);
                    }
                }
            }
            return true;
        }
        

        /// <summary>
        /// Returns true when all cells in board are filled
        /// </summary>
        /// <param name="row">Row where to fill value</param>
        /// <param name="column">Column where to fill value</param>
        /// <returns></returns>
        public bool TryToFillCell(int row,int column)
        {
            for (int value = 1; value < 10; value++)
            {
                if (IsPossibleToFill(row, column, value))
                {
                    _workingBoard.Board[row,column] = value;
                    if (PerformSolver())
                    {
                        return true;
                    }
                    _workingBoard.Board[row,column] = _workingBoard.EmptyNum;
                }
            }

            return false;
        }

        /// <summary>
        /// Check weather value can be inserted in given cell
        /// </summary>
        /// <param name="row">Row where we are trying to fill value</param>
        /// <param name="column">Column where we are trying to fill value</param>
        /// <param name="value">Value to be filled</param>
        /// <returns></returns>
        private bool IsPossibleToFill(int row, int column, in int value)
        {
            return IsNotExistsIn3x3Box(row,column,value) && IsNotExistsInLines(value,row,column);
        }

        /// <summary>
        /// Check weather value exists in 3x3 box
        /// </summary>
        /// <param name="row">Row where we are trying to fill value</param>
        /// <param name="column">Column where we are trying to fill value</param>
        /// <param name="value">Value we are trying to fill</param>
        /// <returns></returns>
        private bool IsNotExistsIn3x3Box(int row,int column,int value)
        {
            var startRow = row - (row % 3);
            var startColumn = column - (column % 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_workingBoard.Board[startRow+i,startColumn+j] == value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Check weather vertical and horizontal line does not contain
        /// number we want to fill
        /// </summary>
        /// <param name="value">Value to be filled</param>
        /// <param name="row">Row where we want to fill value</param>
        /// <param name="column">Column where we want to fill the value</param>
        /// <returns></returns>
        public bool IsNotExistsInLines(int value, int row,int column)
        {
            for (int i = 0; i < 9; i++)
            {
                if (_workingBoard.Board[row,i] == value || _workingBoard.Board[i,column] == value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}