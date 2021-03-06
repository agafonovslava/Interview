// #10 : https://leetcode.com/problems/regular-expression-matching/ 
/***************************************************************************************
* Implement regular expression matching with support for '.' and '*'.
* '.' Matches any single character.
* '*' Matches zero or more of the preceding element.
* The matching should cover the entire input string (not partial).
* The function prototype should be:
* bool IsMatch(const char *s, const char *p)
* Some examples:
* IsMatch("aa","a") → false
* IsMatch("aa","aa") → true
* IsMatch("aaa","aa") → false
* IsMatch("aa", "a*") → true
* IsMatch("aa", ".*") → true
* IsMatch("ab", ".*") → true
* IsMatch("aab", "c*a*b") → true
* Subscribe to see which companies asked this question
* Show Tags
*Example 1:
Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
Example 2:
Input: s = "aa", p = "a*"
Output: true
Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
Example 3:
Input: s = "ab", p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".
Example 4:
Input: s = "aab", p = "c*a*b"
Output: true
Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore, it matches "aab".
Example 5:
Input: s = "mississippi", p = "mis*is*p*."
Output: false
**********************************************************************************/

namespace Algorithms
{
    public class Solution010
    {
        public static bool IsMatchWithDP(string s, string p)
        {
            int m = s.Length, n = p.Length;
            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (p[j - 1] != '.' && p[j - 1] != '*')
                    {
                        if (i > 0 && s[i - 1] == p[j - 1] && dp[i - 1, j - 1])
                            dp[i, j] = true;
                    }
                    else if (p[j - 1] == '.')
                    {
                        if (i > 0 && dp[i - 1, j - 1])
                            dp[i, j] = true;
                    }
                    else if (j > 1)
                    {  //'*' cannot be the 1st element
                        if (dp[i, j - 1] || dp[i, j - 2])  // match 0 or 1 preceding element
                            dp[i, j] = true;
                        else if (i > 0 && (p[j - 2] == s[i - 1] || p[j - 2] == '.') && dp[i - 1, j]) // match multiple preceding elements
                            dp[i, j] = true;
                    }
                }
            }
            return dp[m, n];
        }
        public static bool IsMatch(string s, string p)
        {
            return IsMatch(s, p, 0, 0);
        }
        private static bool IsMatch(string s, string p, int i, int j)
        {
            if (j == p.Length)
            {
                return i == s.Length;
            }
            if (j == p.Length - 1 || p[j + 1] != '*')
            {
                if (i == s.Length || s[i] != p[j] && p[j] != '.')
                    return false;
                else
                    return IsMatch(s, p, i + 1, j + 1);
            }
            //p[J+1] == '*'
            while (i < s.Length && (p[j] == '.' || s[i] == p[j]))
            {
                if (IsMatch(s, p, i, j + 2))
                {
                    return true;
                }
                i++;
            }
            return IsMatch(s, p, i, j + 2);
        }
    }
}

