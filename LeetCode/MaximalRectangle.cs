// #85 : https://leetcode.com/problems/maximal-rectangle/ 
/**********************************************************************************
* Given a 2D binary matrix filled with 0's and 1's, find the largest rectangle containing only 1's and return its area.
* For example, given the following matrix:
* 1 0 1 0 0
* 1 0 1 1 1
* 1 1 1 1 1
* 1 0 0 1 0
* Return 6.
Example 1:
Input: matrix = [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]
Output: 6
Explanation: The maximal rectangle is shown in the above picture.
Example 2:
Input: matrix = []
Output: 0
Example 3:
Input: matrix = [["0"]]
Output: 0
Example 4:
Input: matrix = [["1"]]
Output: 1
Example 5:
Input: matrix = [["0","0"]]
Output: 0
**********************************************************************************/


using System;

namespace Algorithms
{
    public class Solution085
    {
        public static int MaximalRectangle(char[,] matrix)
        {
            if (matrix.Length == 0)
            {
                return 0;
            }
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int[] left = new int[n];
            int[] right = new int[n];
            int[] height = new int[n];
            Array.Fill(left, 0);
            Array.Fill(right, n);
            Array.Fill(height, 0);
            int maxA = 0;
            for (int i = 0; i < m; i++)
            {
                int currLeft = 0;
                int currRight = n;

                //compute height, this can be achieved from either side
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == '1')
                    {
                        height[j]++;
                    }
                    else
                    {
                        height[j] = 0;
                    }
                }

                //compute left, from left to right
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == '1')
                    {
                        left[j] = Math.Max(left[j], currLeft);
                    }
                    else
                    {
                        left[j] = 0;
                        currLeft = j + 1;
                    }
                }

                //compute right, from right to left
                for (int j = n - 1; j >= 0; j--)
                {
                    if (matrix[i,j] == '1')
                    {
                        right[j] = Math.Min(right[j], currRight);
                    }
                    else
                    {
                        right[j] = n;
                        currRight = j;
                    }
                }

                //compute rectangle area, this can be achieved from either side
                for (int j = 0; j < n; j++)
                {
                    maxA = Math.Max(maxA, (right[j] - left[j]) * height[j]);
                }
            }
            return maxA;
        }
    }
}

