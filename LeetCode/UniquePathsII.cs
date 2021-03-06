// #63 : https://leetcode.com/problems/unique-paths-ii/ 
/**********************************************************************************
* Follow up for "Unique Paths":
* Now consider if some obstacles are added to the grids. How many unique paths would there be?
* An obstacle and empty space is marked as 1 and 0 respectively in the grid.
* For example,
* There is one obstacle in the middle of a 3x3 grid as illustrated below.
* 
* [
*   [0,0,0],
*   [0,1,0],
*   [0,0,0]
* ]
* 
* The total number of unique paths is 2.
* 
* Note: m and n will be at most 100.
Example 1:
Input: obstacleGrid = [[0,0,0],[0,1,0],[0,0,0]]
Output: 2
Explanation: There is one obstacle in the middle of the 3x3 grid above.
There are two ways to reach the bottom-right corner:
1. Right -> Right -> Down -> Down
2. Down -> Down -> Right -> Right
Example 2:
Input: obstacleGrid = [[0,1],[0,0]]
Output: 1
Constraints:
m == obstacleGrid.length
n == obstacleGrid[i].length
1 <= m, n <= 100
obstacleGrid[i][j] is 0 or 1.
**********************************************************************************/

namespace Algorithms
{
    public class Solution063
    {
        public static int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid.GetLength(0) == 0 || obstacleGrid.GetLength(1) == 0)
                return 0;
            int[] res = new int[obstacleGrid.GetLength(1)];
            res[0] = 1;
            for (int i = 0; i < obstacleGrid.GetLength(0); i++)
            {
                for (int j = 0; j < obstacleGrid.GetLength(1); j++)
                {
                    if (obstacleGrid[i, j] == 1)
                    {
                        res[j] = 0;
                    }
                    else
                    {
                        if (j > 0)
                            res[j] += res[j - 1];
                    }
                }
            }

            return res[obstacleGrid.GetLength(1) - 1];

        }
    }
}

