// #84 : https://leetcode.com/problems/largest-rectangle-in-histogram/ 

/**********************************************************************************
* Given n non-negative integers representing the histogram's bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.
* Above is a histogram where width of each bar is 1, given height = [2,1,5,6,2,3].
* The largest rectangle is shown in the shaded area, which has area = 10 unit.
* For example,
* Given heights = [2,1,5,6,2,3],
* return 10.
* Example 1:
Input: heights = [2,1,5,6,2,3]
Output: 10
Explanation: The above is a histogram where width of each bar is 1.
The largest rectangle is shown in the red area, which has an area = 10 units.
Example 2:
Input: heights = [2,4]
Output: 4
Constraints:
1 <= heights.length <= 10^5
0 <= heights[i] <= 10^4
**********************************************************************************/

using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Solution084
    {
        public static int LargestRectangleArea(int[] heights)
        {
            var stack = new Stack<int>();

            var index = 0;
            var largestArea = 0;

            int length = heights.Length; // 6

            while (index < length) // true; index = 1; index = 2;
            {
                //     stack empty            going upward
                if (stack.Count == 0 || heights[stack.Peek()] < heights[index]) // index = 1, false;
                {
                    stack.Push(index++); // 0, index = 1;
                }
                else
                {
                    // going downward and then pop stack, calculate rectangle.
                    popStackAndCalculate(ref largestArea, stack, heights, index);
                }
            }

            while (stack.Count > 0)
            {
                popStackAndCalculate(ref largestArea, stack, heights, length);
            }

            return largestArea;
        }

        /// <summary>
        /// downward and then pop stack to calculate the rectangle
        /// </summary>
        private static void popStackAndCalculate(ref int largestArea, Stack<int> stack, int[] height, int rightIndex)
        {
            int length = height.Length; // 6

            int lastHeight = height[stack.Pop()]; // 2
            int width = stack.Count == 0 ? rightIndex : rightIndex - stack.Peek() - 1; // 1

            largestArea = Math.Max(largestArea, lastHeight * width); // 2 * 1
        }
    }
}
