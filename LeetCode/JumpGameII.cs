// #45 : https://leetcode.com/problems/jump-game-ii/ 
/**********************************************************************************
* Given an array of non-negative integers, you are initially positioned at the first index of the array.
* Each element in the array represents your maximum jump length at that position. 
* Your goal is to reach the last index in the minimum number of jumps.
* For example:
* Given array A = [2,3,1,1,4]
* The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)
* Note:
* You can assume that you can always reach the last index.
Example 1:
Input: nums = [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:
Input: nums = [2,3,0,1,4]
Output: 2
Constraints:
1 <= nums.length <= 1000
0 <= nums[i] <= 105
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution045
    {
        public static int Jump(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int lastReach = 0;
            int reach = 0;
            int step = 0;
            for (int i = 0; i <= reach && i < nums.Length; i++)
            {
                if (i > lastReach)
                {
                    step++;
                    lastReach = reach;
                }
                reach = Math.Max(reach, nums[i] + i);
            }

            return reach < nums.Length - 1 ? 0 : step;
        }
    }
}

