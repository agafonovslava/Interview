// #36 : https://leetcode.com/problems/valid-sudoku/ 
/**********************************************************************************
* Determine if a Sudoku is valid, according to: Sudoku Puzzles - The Rules.
* The Sudoku board could be partially filled, where empty cells are filled with the character '.'.
* A partially filled sudoku which is valid.
* Note:
* A valid Sudoku board (partially filled) is not necessarily solvable. Only the filled cells need to be validated.
Example 1:
Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
Constraints:
board.length == 9
board[i].length == 9
board[i][j] is a digit or '.'.
**********************************************************************************/

using System.Collections.Generic;

namespace Algorithms
{
    public class Solution036
    {
        public static bool IsValidSudoku(char[,] board)
        {
            if (board.Length != 81 && board.GetLength(0) != 9)
            {
                return false;
            }
            // check Row
            for (int i = 0; i < 9; i++)
            {
                ISet<int> existed = new HashSet<int>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == '.') continue;
                    int k = board[i, j] - '0';
                    if (k == 0 || !existed.Add(k)) return false;
                }
            }

            //check Column
            for (int j = 0; j < 9; j++)
            {
                ISet<int> existed = new HashSet<int>();
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, j] == '.') continue;
                    int k = board[i, j] - '0';
                    if (k == 0 || !existed.Add(k)) return false;
                }
            }

            // check Box
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int row = 3 * i;
                    int col = 3 * j;
                    ISet<int> existed = new HashSet<int>();
                    for (int m = row; m < row + 3; m++)
                    {
                        for (int n = col; n < col + 3; n++)
                        {
                            if (board[m, n] == '.') continue;
                            int k = board[m, n] - '0';
                            if (k == 0 || !existed.Add(k)) return false;
                        }
                    }
                }
            }

            return true;
        }

        public static bool IsValidSudoku2(char[,] board)
        {

            for (int i = 0; i < 9; i++)
            {
                int[] rowValid = new int[10];
                int[] columnValid = new int[10];
                int[] boxValid = new int[10];
                for (int j = 0; j < 9; j++)
                {
                    var m = 3 * (i / 3) + j / 3;
                    var n = 3 * (i % 3) + j % 3;
                    if (!checkValid(rowValid, board[i, j] - '0') ||
                        !checkValid(columnValid, board[j, i] - '0') ||
                        !checkValid(boxValid, board[m, n] - '0'))
                        return false;

                }
            }
            return true;
        }

        static bool checkValid(int[] existed, int val)
        {
            if (val < 0) return true;
            if (existed[val] == 1) return false;
            existed[val] = 1;
            return true;
        }
    }
}
