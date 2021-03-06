// #51 : https://leetcode.com/problems/n-queens/ 
/**********************************************************************************
* The n-queens puzzle is the problem of placing n queens on an n?n chessboard such that no two queens attack each other.
* Given an integer n, return all distinct solutions to the n-queens puzzle.
* Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space respectively.
* For example,
* There exist two distinct solutions to the 4-queens puzzle:
* [
*  [".Q..",  // Solution 1
*   "...Q",
*   "Q...",
*   "..Q."],
* 
*  ["..Q.",  // Solution 2
*   "Q...",
*   "...Q",
*   ".Q.."]
* ]
Example 1:
Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above
Example 2:
Input: n = 1
Output: [["Q"]]
Constraints:
1 <= n <= 9
**********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Solution051
    {
        public static IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> res = new List<IList<string>>();
            helper(n, 0, new int[n], res);
            return res;
        }
        private static void helper(int n, int row, int[] columnForRow, IList<IList<string>> res)
        {
            if (row == n)
            {
                string[] strN = new string[n];
                IList<string> item = new List<string>(strN);
                for (int i = 0; i < n; i++)
                {
                    StringBuilder strRow = new StringBuilder();
                    for (int j = 0; j < n; j++)
                    {
                        if (columnForRow[i] == j)
                            strRow.Append('Q');
                        else
                            strRow.Append('.');
                    }
                    item[i] = strRow.ToString();
                }
                res.Add(item);
                return;
            }
            for (int i = 0; i < n; i++)
            {
                columnForRow[row] = i;
                if (check(row, columnForRow))
                {
                    helper(n, row + 1, columnForRow, res);
                }
            }
        }
        private static bool check(int row, int[] columnForRow)
        {
            for (int i = 0; i < row; i++)
            {
                if (columnForRow[row] == columnForRow[i] || Math.Abs(columnForRow[row] - columnForRow[i]) == row - i)
                    return false;
            }
            return true;
        }
    }
}

