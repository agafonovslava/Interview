// #37 : https://leetcode.com/problems/sudoku-solver/ 
/**********************************************************************************
* Write a program to solve a Sudoku puzzle by filling the empty cells.
* Empty cells are indicated by the character '.'.
* You may assume that there will be only one unique solution.
* A sudoku puzzle...
* ...and its solution numbers marked in red.
Example 1:
Input: board = [["5","3",".",".","7",".",".",".","."],["6",".",".","1","9","5",".",".","."],[".","9","8",".",".",".",".","6","."],["8",".",".",".","6",".",".",".","3"],["4",".",".","8",".","3",".",".","1"],["7",".",".",".","2",".",".",".","6"],[".","6",".",".",".",".","2","8","."],[".",".",".","4","1","9",".",".","5"],[".",".",".",".","8",".",".","7","9"]]
Output: [["5","3","4","6","7","8","9","1","2"],["6","7","2","1","9","5","3","4","8"],["1","9","8","3","4","2","5","6","7"],["8","5","9","7","6","1","4","2","3"],["4","2","6","8","5","3","7","9","1"],["7","1","3","9","2","4","8","5","6"],["9","6","1","5","3","7","2","8","4"],["2","8","7","4","1","9","6","3","5"],["3","4","5","2","8","6","1","7","9"]]
Explanation: The input board is shown above and the only valid solution is shown below:
Constraints:
board.length == 9
board[i].length == 9
board[i][j] is a digit or '.'.
It is guaranteed that the input board has only one solution.
**********************************************************************************/

namespace Algorithms
{
    public class Solution037
    {
        public static char[,] SolveSudoku(char[,] board)
        {
            if (board.Length != 81 || board.GetLength(0) != 9)
            {
                return null;
            }
            SolveSudoku(board, 0, 0);
            return board;
        }
        private static bool SolveSudoku(char[,] board, int i, int j)
        {
            if (i == 9) return true;
            if (j >= 9) return SolveSudoku(board, i + 1, 0);
            if (board[i, j] == '.')
            {
                for (int k = 1; k <= 9; k++)
                {
                    board[i, j] = (char)(k + '0');
                    if (IsValid(board, i, j))
                    {
                        if (SolveSudoku(board, i, j + 1))
                            return true;
                    }
                }
            }
            else
            {
                return SolveSudoku(board, i, j + 1);
            }
            board[i, j] = '.';
            return false;
        }

        private static bool IsValid(char[,] board, int i, int j)
        {
            for (int k = 0; k < 9; k++)
            {
                if (k != j && board[i, k] == board[i, j])
                    return false;
            }

            for (int k = 0; k < 9; k++)
            {
                if (k != i && board[k, j] == board[i, j])
                    return false;
            }

            for (int row = i / 3 * 3; row < i / 3 * 3 + 3; row++)
            {
                for (int col = j / 3 * 3; col < j / 3 * 3 + 3; col++)
                {
                    if ((row != i || col != j) && board[row, col] == board[i, j])
                        return false;
                }
            }

            return true;
        }
    }
}

