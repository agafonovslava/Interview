// #78 : https://leetcode.com/problems/subsets/ 
/**********************************************************************************
* Given a set of distinct integers, nums, return all possible subsets.
* Note: The solution set must not contain duplicate subsets.
* For example,
* If nums = [1,2,3], a solution is:
* [
*   [3],
*   [1],
*   [2],
*   [1,2,3],
*   [1,3],
*   [2,3],
*   [1,2],
*   []
* ]
Example 1:
Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
Example 2:
Input: nums = [0]
Output: [[],[0]]
Constraints:
1 <= nums.length <= 10
-10 <= nums[i] <= 10
All the numbers of nums are unique.
**********************************************************************************/

using System;
using System.Collections.Generic;
namespace Algorithms
{
    public class Solution078
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            IList<int> list = new List<int>();
            Array.Sort(nums);
            return Helper(nums, nums.Length - 1);
        }
        private static IList<IList<int>> Helper(int[] num, int pos)
        {
            if (pos == -1)
            {
                IList<IList<int>> res = new List<IList<int>>();
                IList<int> elem = new List<int>();
                res.Add(elem);
                return res;
            }
            else
            {
                IList<IList<int>> res = Helper(num, pos - 1);
                int size = res.Count;
                for (int i = 0; i < size; i++)
                {
                    IList<int> elem = new List<int>(res[i]);
                    elem.Add(num[pos]);
                    res.Add(elem);
                }
                return res;
            }
        }
    }
}

