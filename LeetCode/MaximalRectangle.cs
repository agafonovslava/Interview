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
using System.Collections.Generic;

namespace Algorithms
{
    public class Solution085
    {
        public static int MaximalRectangle(char[,] matrix)
        {
            if (matrix.Length == 0)
                return 0;

            int area = 0;
            int[] arr = new int[matrix.Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '0')
                    {
                        arr[j] = 0;
                    }
                    else
                    {
                        arr[j] += 1;
                    }
                }

            return Math.Max(area, maxArea(arr));
        }

        private static int maxArea(int[] arr)
        {
            int area = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count == 0 || arr[stack.Peek()] <= arr[i])
                    stack.Push(i);
                else
                {
                    while (stack.Count != 0 && arr[stack.Peek()] > arr[i])
                        area = Math.Max(area, arr[stack.Pop()] * (stack.Count == 0 ? i : i - stack.Peek() - 1));
                    stack.Push(i);
                }
            }

            while (stack.Count != 0)
            {
                int top = stack.Pop();
                area = Math.Max(area, arr[top] * (stack.Count == 0 ? arr.Length : arr.Length - stack.Peek() - 1));
            }

            return area;
        }
    }
}

