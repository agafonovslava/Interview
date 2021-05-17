// Source : https://leetcode.com/problems/rotate-image/ 

/**********************************************************************************
*
* You are given an n x n 2D matrix representing an image.
* Rotate the image by 90 degrees (clockwise).
* Follow up:
* Could you do this in-place?
*
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

