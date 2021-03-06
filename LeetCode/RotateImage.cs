// #48 : https://leetcode.com/problems/rotate-image/ 
/**********************************************************************************
* You are given an n x n 2D matrix representing an image.
* Rotate the image by 90 degrees (clockwise).
* Follow up:
* Could you do this in-place?
Example 1:
Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[7,4,1],[8,5,2],[9,6,3]]
Example 2:
Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
Example 3:
Input: matrix = [[1]]
Output: [[1]]
Example 4:
Input: matrix = [[1,2],[3,4]]
Output: [[3,1],[4,2]]
Constraints:
matrix.length == n
matrix[i].length == n
1 <= n <= 20
-1000 <= matrix[i][j] <= 1000
**********************************************************************************/

namespace Algorithms
{
    public class Solution048
    {
        public static int[,] Rotate(int[,] matrix)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            for (var i = 0; i < m / 2; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var temp = matrix[i, j];
                    matrix[i, j] = matrix[n - 1 - i, j];
                    matrix[n - 1 - i, j] = temp;
                }
            }

            for (var i = 0; i < m; ++i)
            {
                for (var j = i + 1; j < n; ++j)
                {
                    var temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            return matrix;
        }
    }
}

