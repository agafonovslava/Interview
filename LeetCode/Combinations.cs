// #77 : https://leetcode.com/problems/combinations/ 

/**********************************************************************************
* Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.
* For example,
* If n = 4 and k = 2, a solution is:
* [
*   [2,4],
*   [3,4],
*   [2,3],
*   [1,2],
*   [1,3],
*   [1,4],
* ]
Example 1:
Input: n = 4, k = 2
Output:
[
  [2,4],
  [3,4],
  [2,3],
  [1,2],
  [1,3],
  [1,4],
]
Example 2:
Input: n = 1, k = 1
Output: [[1]]
Constraints:
1 <= n <= 20
1 <= k <= n
**********************************************************************************/

using System.Collections.Generic;

namespace Algorithms
{
    public class Solution077
    {
        public static List<List<int>> Combine(int n, int k)
        {
            List<List<int>> combs = new List<List<int>>();
            combine(combs, new List<int>(), 1, n, k);
            return combs;
        }

        public static void combine(List<List<int>> combs, List<int> comb, int start, int n, int k)
        {
            if (k == 0)
            {
                combs.Add(new List<int>(comb));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                comb.Add(i);
                combine(combs, comb, i + 1, n, k - 1);
                comb.RemoveAt(comb.Count - 1);
            }
        }
    }
}

