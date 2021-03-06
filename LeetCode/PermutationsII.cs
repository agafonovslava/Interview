// #47 : https://leetcode.com/problems/permutations-ii/ 
/**********************************************************************************
* Given a collection of numbers that might contain duplicates, return all possible unique permutations.
* For example,
* [1,1,2] have the following unique permutations:
* [
*   [1,1,2],
*   [1,2,1],
*   [2,1,1]
* ]
Example 1:
Input: nums = [1,1,2]
Output:
[[1,1,2],
 [1,2,1],
 [2,1,1]]
Example 2:
Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
Constraints:
1 <= nums.length <= 8
-10 <= nums[i] <= 10
**********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Solution047
    {
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length == 0) return result;
            IList<int> first = new List<int>();
            first.Add(nums[0]);
            result.Add(first);
            for (int i = 1; i < nums.Length; i++)
            {
                IList<IList<int>> newresult = new List<IList<int>>();
                for (int j = 0; j < result.Count; j++)
                {
                    IList<int> cur = result[j];
                    for (int k = 0; k < cur.Count + 1; k++)
                    {
                        IList<int> item = new List<int>(cur);
                        item.Insert(k, nums[i]);
                        if (newresult.Any(x => x.SequenceEqual(item)))
                        {
                            continue;
                        }
                        newresult.Add(item);
                    }
                }
                result = newresult;
            }

            return result;
        }
    }
}

