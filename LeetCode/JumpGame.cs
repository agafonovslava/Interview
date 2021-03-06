// #55 : https://leetcode.com/problems/jump-game/ 
/**********************************************************************************
* Given an array of non-negative integers, you are initially positioned at the first index of the array.
* Each element in the array represents your maximum jump length at that position. 
* Determine if you are able to reach the last index.
* For example:
* A = [2,3,1,1,4], return true.
* A = [3,2,1,0,4], return false.
*Example 1:
Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:
Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
Constraints:
1 <= nums.length <= 3 * 104
0 <= nums[i] <= 105
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution055
    {
        public static bool CanJump(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;
            int reach = 0;
            for (int i = 0; i <= reach && i < nums.Length; i++)
            {
                reach = Math.Max(nums[i] + i, reach);
            }

            return reach >= nums.Length - 1;
        }
    }
}

