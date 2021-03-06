// #59 : https://leetcode.com/problems/spiral-matrix-ii/ 
/**********************************************************************************
* Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.
* For example,
* Given n = 3,
* You should return the following matrix:
* [
*  [ 1, 2, 3 ],
*  [ 8, 9, 4 ],
*  [ 7, 6, 5 ]
* ]
Example 1:
Input: n = 3
Output: [[1,2,3],[8,9,4],[7,6,5]]
Example 2:
Input: n = 1
Output: [[1]]
Constraints:
1 <= n <= 20
**********************************************************************************/

namespace Algorithms
{
    public class Solution059
    {
        public static int[,] GenerateMatrix(int n)
        {
            if (n < 0) return null;
            var result = new int[n, n];
            var top = 0;
            var bottom = n - 1;
            var left = 0;
            var right = n - 1;
            var num = 1;
            while (top <= bottom)
            {
                if (top == bottom)
                {
                    result[top, top] = num++;
                }
                //first line
                for (int i = left; i < right; i++)
                {
                    result[top, i] = num++;
                }
                //right line
                for (int i = top; i < bottom; i++)
                {
                    result[i, right] = num++;
                }
                //bottom line
                for (int i = right; i > left; i--)
                {
                    result[bottom, i] = num++;
                }
                //left line 
                for (int i = bottom; i > top; i--)
                {
                    result[i, left] = num++;
                }
                top++;
                bottom--;
                left++;
                right--;
            }

            return result;
        }
    }
}

