// #18 : https://leetcode.com/problems/4sum/ 
/***************************************************************************************
* Given an array S of n integers, are there elements a, b, c, and d in S such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.
* Note: The solution set must not contain duplicate quadruplets.
* For example, given array S = [1, 0, -1, 0, -2, 2], and target = 0.
* A solution set is:
* [
*   [-1,  0, 0, 1],
*   [-2, -1, 1, 2],
*   [-2,  0, 0, 2]
* ]
Example 1:
Input: nums = [1,0,-1,0,-2,2], target = 0
Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
Example 2:
Input: nums = [2,2,2,2,2], target = 8
Output: [[2,2,2,2]]
Constraints:
1 <= nums.length <= 200
-109 <= nums[i] <= 109
-109 <= target <= 109
**********************************************************************************/

using Algorithms.Utils;
using System.Collections.Generic;

namespace Algorithms
{
    public class Solution018
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            int n = nums.Length;
            IList<IList<int>> res = new List<IList<int>>();
            Helper.Sort(nums);
            for (var i = 0; i < n - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < n - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int target2 = target - nums[i] - nums[j];
                    int head = j + 1, tail = n - 1;
                    while (head < tail)
                    {
                        int tmp = nums[head] + nums[tail];
                        if (tmp > target2)
                        {
                            tail--;
                        }
                        else if (tmp < target2)
                        {
                            head++;
                        }
                        else
                        {
                            res.Add(new List<int>
                            {
                                nums[i], nums[j], nums[head], nums[tail]
                            });

                            int k = head + 1;
                            while (k < tail && nums[k] == nums[head])
                            {
                                k++;
                            }
                            head = k;
                            k = tail - 1;
                            while (k > head && nums[k] == nums[tail])
                            {
                                k--;
                            }
                            tail = k;
                        }

                    }
                }
            }
            return res;
        }
    }
}

