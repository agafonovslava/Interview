// #44 : https://leetcode.com/problems/wildcard-matching/ 
/**********************************************************************************
* Implement wildcard pattern matching with support for '?' and '*'.
* '?' Matches any single character.
* '*' Matches any sequence of characters (including the empty sequence).
* The matching should cover the entire input string (not partial).
* The function prototype should be:
* bool isMatch(const char *s, const char *p)
* Some examples:
* isMatch("aa","a") ? false
* isMatch("aa","aa") ? true
* isMatch("aaa","aa") ? false
* isMatch("aa", "*") ? true
* isMatch("aa", "a*") ? true
* isMatch("ab", "?*") ? true
* isMatch("aab", "c*a*b") ? false
Example 1:
Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
Example 2:
Input: s = "aa", p = "*"
Output: true
Explanation: '*' matches any sequence.
Example 3:
Input: s = "cb", p = "?a"
Output: false
Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.
Example 4:
Input: s = "adceb", p = "*a*b"
Output: true
Explanation: The first '*' matches the empty sequence, while the second '*' matches the substring "dce".
Example 5:
Input: s = "acdcb", p = "a*c?b"
Output: false
**********************************************************************************/

namespace Algorithms
{
    public class Solution044
    {
        public static bool IsMatch(string s, string p)
        {
            if (p.Length == 0)
                return s.Length == 0;
            bool[] res = new bool[s.Length + 1];
            res[0] = true;
            for (int j = 0; j < p.Length; j++)
            {
                if (p[j] != '*')
                {
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        res[i + 1] = res[i] && (p[j] == '?' || s[i] == p[j]);
                    }
                }
                else
                {
                    int i = 0;
                    while (i <= s.Length && !res[i])
                        i++;
                    for (; i <= s.Length; i++)
                    {
                        res[i] = true;
                    }
                }
                res[0] = res[0] && p[j] == '*';
            }
            return res[s.Length];
        }
    }
}

