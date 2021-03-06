// #97 : https://leetcode.com/problems/interleaving-string 

/**********************************************************************************
* Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.
* 
* For example,
* Given:
* s1 = "aabcc",
* s2 = "dbbca",
* When s3 = "aadbbcbcac", return true.
* When s3 = "aadbbbaccc", return false.
* 
*Example 1:
Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac"
Output: true
Example 2:
Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc"
Output: false
Example 3:
Input: s1 = "", s2 = "", s3 = ""
Output: true
**********************************************************************************/

namespace Algorithms
{
    public class Solution097
    {
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            if (string.IsNullOrWhiteSpace(s1) ||
                string.IsNullOrWhiteSpace(s2) ||
                string.IsNullOrWhiteSpace(s3))
                return false;

            var length1 = s1.Length;
            var length2 = s2.Length;
            var length3 = s3.Length;

            if (length1 == 0)
                return s2.CompareTo(s3) == 0;
            if (length2 == 0)
                return s1.CompareTo(s3) == 0;

            if (length1 + length2 != length3)
                return false;  // caught by online judge, index out of range

            var dp = new bool[length1 + 1, length2 + 1];

            dp[0, 0] = true;

            // base case: first column, go over s1 first
            for (int row = 1; row < length1 + 1; row++)
            {
                dp[row, 0] = s1[row - 1] == s3[row - 1] && dp[row - 1, 0];
            }

            // base case: first row
            for (int col = 1; col < length2 + 1; col++)
            {
                dp[0, col] = s2[col - 1] == s3[col - 1] && dp[0, col - 1];
            }

            for (int row = 1; row < length1 + 1; row++)
            {
                for (int col = 1; col < length2 + 1; col++)
                {
                    var index = row + col - 1; // work on base case: "a", "b", "ab"

                    dp[row, col] = (s1[row - 1] == s3[index] && dp[row - 1, col]) ||
                                   (s2[col - 1] == s3[index] && dp[row, col - 1]);
                }
            }

            return dp[length1, length2];
        }
    }
}

