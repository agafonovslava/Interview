// #70 : https://leetcode.com/problems/climbing-stairs/ 

/**********************************************************************************
* You are climbing a stair case. It takes n steps to reach to the top.
* Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
* Note: Given n will be a positive integer.
*Example 1:
Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:
Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
Constraints:
1 <= n <= 45
**********************************************************************************/

namespace Algorithms
{
    public class Solution070
    {
        public static int ClimbStairs(int n)
        {
            int[] m = new int[n + 1];
            return ways(n, m);

        }

        private static int ways(int n, int[] m)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            if (m[n] != 0)
            {
                return m[n];
            }
            m[n] = ways(n - 1, m) + ways(n - 2, m);
            return m[n];
        }
    }
}

