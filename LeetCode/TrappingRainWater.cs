// #42 : https://leetcode.com/problems/trapping-rain-water/ 
/**********************************************************************************
* Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining. 
* For example, 
* Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.
* The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!
Example 1:
Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
Example 2:
Input: height = [4,2,0,3,2,5]
Output: 9
Constraints:
n == height.length
0 <= n <= 3 * 10^4
0 <= height[i] <= 10^5
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution042
    {
        public static int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }

            int i = 0, j = height.Length - 1;

            int area = 0;

            int left = height[i];
            int right = height[j];

            int min = 0;
            while (i <= j)
            {
                min = Math.Min(left, right);
                if (left <= right)
                {
                    area += Math.Max(0, min - height[i]);
                    left = Math.Max(min, height[i]);
                    i++;
                }
                else
                {
                    area += Math.Max(0, min - height[j]);
                    right = Math.Max(min, height[j]);
                    j--;
                }
            }
            return area;

        }
    }
}

