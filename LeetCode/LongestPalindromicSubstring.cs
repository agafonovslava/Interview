// #5 : https://leetcode.com/problems/longest-palindromic-substring/
/*************************************************************************************** 
 * Given a string S, find the longest palindromic substring in S. You may assume that 
 * the maximum length of S is 1000, and there exists one unique longest palindromic 
 * substring.
Example 1:
Input: s = "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:
Input: s = "cbbd"
Output: "bb"
Example 3:
Input: s = "a"
Output: "a"
Example 4:
Input: s = "ac"
Output: "a"
Constraints:
1 <= s.length <= 1000
s consist of only digits and English letters (lower-case and/or upper-case),
 ***************************************************************************************/
namespace Algorithms
{
    public class Solution005
    {
        public static string LongestPalindromicSubstring(string s)
        {
            var n = s.Length;
            if (n == 0)
            {
                return "";
            }
            var longest = s.Substring(0, 1);
            for (var i = 0; i < n - 1; i++)
            {
                var s1 = ExpandAroundCenter(s, i, i);
                if (s1.Length > longest.Length)
                {
                    longest = s1;
                }
                var s2 = ExpandAroundCenter(s, i, i + 1);
                if (s2.Length > longest.Length)
                {
                    longest = s2;
                }
            }

            return longest;
        }

        private static string ExpandAroundCenter(string s, int left, int right)
        {
            var L = left;
            var R = right;
            var N = s.Length;
            while (L >= 0 && R <= N - 1 && s[L] == s[R])
            {
                L--;
                R++;
            }
            return s.Substring(L + 1, R - L - 1);
        }
    }
}
