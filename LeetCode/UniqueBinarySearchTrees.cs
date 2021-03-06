// #96 : https://leetcode.com/problems/unique-binary-search-trees 

/**********************************************************************************
* Given n, how many structurally unique BST's (binary search trees) that store values 1...n?
* For example,
* Given n = 3, there are a total of 5 unique BST's.
*    1         3     3      2      1
*     \       /     /      / \      \
*      3     2     1      1   3      2
*     /     /       \                 \
*    2     1         2                 3
* Example 1:
Input: n = 3
Output: 5
Example 2:
Input: n = 1
Output: 1
Constraints:
1 <= n <= 19
**********************************************************************************/

namespace Algorithms
{
    public class Solution096
    {
        /// <summary>
        /// https://miafish.wordpress.com/2015/02/27/leetcode-ojc-unique-binary-search-trees/
        public static int NumTrees(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            return dp[n];
        }
    }
}

