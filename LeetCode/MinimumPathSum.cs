// #64 : https://leetcode.com/problems/minimum-path-sum/ 
/**********************************************************************************
* Given a m x n grid filled with non-negative numbers, 
* find a path from top left to bottom right which minimizes the sum of all numbers along its path.
* Note: You can only move either down or right at any point in time.
*Example 1:
Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
Output: 7
Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
Example 2:
Input: grid = [[1,2,3],[4,5,6]]
Output: 12
Constraints:
m == grid.length
n == grid[i].length
1 <= m, n <= 200
0 <= grid[i][j] <= 100
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution064
    {
        public static int MinPathSum(int[,] grid)
        {
            if (grid == null || grid.GetLength(0) == 0 || grid.GetLength(1) == 0)
                return 0;

            int[] res = new int[grid.GetLength(1)];
            res[0] = grid[0, 0];

            for (int i = 1; i < grid.GetLength(1); i++)
            {
                res[i] = res[i - 1] + grid[0, i];
            }
            for (int i = 1; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (j == 0)
                        res[j] += grid[i, j];
                    else
                        res[j] = Math.Min(res[j - 1], res[j]) + grid[i, j];
                }
            }

            return res[grid.GetLength(1) - 1];

        }
    }
}

