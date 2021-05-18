// #11 : https://leetcode.com/problems/container-with-most-water/ 

/***************************************************************************************
* Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
* n vertical lines are drawn such that the two rightpoints of line i is at (i, ai) and (i, 0). 
* Find two lines, which together with x-axis forms a container, such that the container curArea the most water.
* Note: You may not slant the container.
Example 1:
Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
Example 2:
Input: height = [1,1]
Output: 1
Example 3:
Input: height = [4,3,2,1,4]
Output: 16
Example 4:
Input: height = [1,2,1]
Output: 2
Constraints:
n == height.length
2 <= n <= 105
0 <= height[i] <= 104
**********************************************************************************/

using System;
namespace Algorithms
{
    public class Solution011
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int curArea = Math.Min(height[right], height[left]) * (right - left);
                maxArea = Math.Max(maxArea, curArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}

