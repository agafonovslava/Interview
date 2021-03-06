// #90 : https://leetcode.com/problems/subsets-ii/?tab=Description 
/**********************************************************************************
* Given a collection of integers that might contain duplicates, nums, return all possible subsets.
* Note: The solution set must not contain duplicate subsets.
* For example,
* If nums = [1,2,2], a solution is:
* [
*   [2],
*   [1],
*   [1,2,2],
*   [2,2],
*   [1,2],
*   []
* ]
Example 1:
Input: nums = [1,2,2]
Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
Example 2:
Input: nums = [0]
Output: [[],[0]]
Constraints:
1 <= nums.length <= 10
-10 <= nums[i] <= 10
**********************************************************************************/

using System;
using System.Collections.Generic;
namespace Algorithms
{
    public class Solution090
    {
        public static List<List<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            var res = new List<List<int>>();
            var solution = new List<int>();
            SubsetsRecursion(nums, 0, res, solution);
            return res;
        }

        private static void SubsetsRecursion(int[] nums, int index, List<List<int>> res, List<int> solution)
        {
            if (index >= nums.Length)
            {
                res.Add(new List<int>(solution));
                return;
            }

            // add item nums[index] 
            solution.Add(nums[index]);
            SubsetsRecursion(nums, index + 1, res, solution);
            solution.RemoveAt(solution.Count - 1);

            // do not add nums[index]
            SubsetsRecursion(nums, index + 1, res, solution);
        }
    }
}

