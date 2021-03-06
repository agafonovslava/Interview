// #16 : https://leetcode.com/problems/3sum-closest/ 
/***************************************************************************************
* Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target. 
* Return the sum of the three integers. 
* You may assume that each input would have exactly one solution.
*     For example, given array S = {-1 2 1 -4}, and target = 1.
*     The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
Example 1:
Input: nums = [-1,2,1,-4], target = 1
Output: 2
Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
Constraints:
3 <= nums.length <= 10^3
-10^3 <= nums[i] <= 10^3
-10^4 <= target <= 10^4
**********************************************************************************/

using Algorithms.Utils;
using System;

namespace Algorithms
{
    public class Solution016
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            var result = 0;
            var minDiff = int.MaxValue;
            Helper.BubbleSort2(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                var j = i + 1;
                var k = nums.Length - 1;
                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    var diff = Math.Abs(sum - target);
                    if (minDiff > diff)
                    {
                        result = sum;
                        minDiff = diff;
                    }
                    else if (sum < target)
                    {
                        j++;
                    }
                    else if (sum > target)
                    {
                        k--;
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            return result;
        }

        public static int ThreeSumClosest2(int[] nums, int target)
        {
            if (nums.Length < 3)
                throw new Exception();

            Helper.BubbleSort3(nums);
            var minDiff = int.MaxValue;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int diff = nums[i] + nums[left] + nums[right] - target;
                    if (Math.Abs(diff) < Math.Abs(minDiff))
                    {
                        minDiff = diff;
                    }
                    if (diff == 0)
                    {
                        break;
                    }
                    else if (diff < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return target + minDiff;
        }
    }
}

