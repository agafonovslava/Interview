// #53 : https://leetcode.com/problems/maximum-subarray/ 
/**********************************************************************************
* Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
* For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
* the contiguous subarray [4,-1,2,1] has the largest sum = 6.
* click to show more practice.
* More practice:
* If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
*Example 1:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
Example 2:
Input: nums = [1]
Output: 1
Example 3:
Input: nums = [5,4,-1,7,8]
Output: 23
Constraints:
1 <= nums.length <= 3 * 10^4
-10^5 <= nums[i] <= 10^5
Follow up: If you have figured out the O(n) solution, 
try coding another solution using the divide and conquer approach, which is more subtle.
**********************************************************************************/

using System;

namespace Algorithms
{
    public class Solution053
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int global = nums[0];
            int local = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                local = Math.Max(nums[i], local + nums[i]);
                global = Math.Max(local, global);
            }

            return global;
        }
    }
}

