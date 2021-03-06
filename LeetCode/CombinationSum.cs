// #39 : https://leetcode.com/problems/combination-sum/ 

/**********************************************************************************
* Given a set of candidate numbers (C) and a target number (T), 
* find all unique combinations in C where the candidate numbers sums to T. 
* The same repeated number may be chosen from C unlimited number of times.
* Note:
* All numbers (including target) will be positive ints.
* The solution set must not contain duplicate combinations.
* For example, given candidate set [2, 3, 6, 7] and target 7, 
* A solution set is: 
* [
*   [7],
*   [2, 2, 3]
* ]
*Example 1:
Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.
Example 2:
Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]
Example 3:
Input: candidates = [2], target = 1
Output: []
Example 4:
Input: candidates = [1], target = 1
Output: [[1]]
Example 5:
Input: candidates = [1], target = 2
Output: [[1,1]]
Constraints:
1 <= candidates.length <= 30
1 <= candidates[i] <= 200
All elements of candidates are distinct.
1 <= target <= 500
**********************************************************************************/

using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Solution039
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (candidates == null || candidates.Length == 0)
                return result;

            Array.Sort(candidates);
            helper(candidates, 0, target, new List<int>(), result);
            return result;
        }

        private static void helper(
            int[] candidates,
            int start,
            int target,
            IList<int> item,
            IList<IList<int>> result)
        {
            if (target < 0)
                return;

            if (target == 0)
            {
                result.Add(new List<int>(item));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > 0 && candidates[i] == candidates[i - 1])
                    continue;

                item.Add(candidates[i]);
                helper(candidates, i, target - candidates[i], item, result);
                item.RemoveAt(item.Count - 1);
            }
        }
    }
}

