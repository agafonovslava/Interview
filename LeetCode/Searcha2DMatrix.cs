// #74 : https://leetcode.com/problems/search-a-2d-matrix/ 
/**********************************************************************************
* Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
* Integers in each row are sorted from left to right.
* The first integer of each row is greater than the last integer of the previous row.
* For example,
* Consider the following matrix:
* [
*   [1,   3,  5,  7],
*   [10, 11, 16, 20],
*   [23, 30, 34, 50]
* ]
* Given target = 3, return true.
Example 1:
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
Output: true
Example 2:
Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
Output: false
Constraints:
m == matrix.length
n == matrix[i].length
1 <= m, n <= 100
-10^4 <= matrix[i][j], target <= 10^4
**********************************************************************************/

namespace Algorithms
{
    public class Solution074
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
                return false;

            int l = 0;
            int r = matrix.GetLength(0) - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (matrix[mid, 0] == target)
                    return true;
                if (matrix[mid, 0] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            int row = r;
            if (row < 0)
                return false;
            l = 0;
            r = matrix.GetLength(1) - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (matrix[row, mid] == target)
                    return true;
                if (matrix[row, mid] > target)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return false;
        }
    }
}

