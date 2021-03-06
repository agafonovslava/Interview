// #79 : https://leetcode.com/problems/word-search/ 
/**********************************************************************************
* Given a 2D board and a word, find if the word exists in the grid.
* The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.
* 
* For example,
* Given board = 
* [
*   ['A','B','C','E'],
*   ['S','F','C','S'],
*   ['A','D','E','E']
* ]
* word = "ABCCED", -> returns true,
* word = "SEE", -> returns true,
* word = "ABCB", -> returns false.
Example 1:
Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
Output: true
Example 2:
Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
Output: true
Example 3:
Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"
Output: false
Constraints:
m == board.length
n = board[i].length
1 <= m, n <= 6
1 <= word.length <= 15
board and word consists of only lowercase and uppercase English letters.
**********************************************************************************/

namespace Algorithms
{
    public class Solution079
    {
        /// <summary>
        /// https://leetcode.com/problems/word-search/discuss/893316/c-word-search-dfs-algorithm
        /// </summary>
        public static bool Exist(char[,] board, string word)
        {
            if (board == null ||
                board.Length == 0 ||
                board.GetLength(0) == 0 ||
                word == null ||
                word.Length == 0)
            {
                return false;
            }

            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var visit = board[row, col];
                    var matchFirstChar = visit == word[0];

                    if (!matchFirstChar)
                    {
                        continue;
                    }

                    var memo = new bool[rows, cols];
                    bool foundOne = searchWord(board, word, row, col, 0, memo);

                    if (foundOne)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// search char by char in given word
        /// </summary>
        private static bool searchWord(
            char[,] board,
            string word,
            int startRow,
            int startCol,
            int index,
            bool[,] memo)
        {
            // checklist: length check, matrix boundary, visited check, 
            if (index > word.Length || !isInBoundary(board, startRow, startCol) || memo[startRow, startCol])
            {
                return false;
            }

            var current = board[startRow, startCol];
            var length = word.Length;

            if (current != word[index])
            {
                return false;
            }

            // base case 
            if (index == (length - 1))
            {
                return true;
            }

            memo[startRow, startCol] = true;

            var nextIndex = index + 1;

            var result =
                   searchWord(board, word, startRow, startCol - 1, nextIndex, memo) ||
                   searchWord(board, word, startRow, startCol + 1, nextIndex, memo) ||
                   searchWord(board, word, startRow - 1, startCol, nextIndex, memo) ||
                   searchWord(board, word, startRow + 1, startCol, nextIndex, memo);

            // backtracking
            if (!result)
            {
                memo[startRow, startCol] = false;
            }

            return result;
        }

        private static bool isInBoundary(char[,] board, int startRow, int startCol)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            return startRow >= 0 && startRow < rows && startCol >= 0 && startCol < cols;
        }
    }
}